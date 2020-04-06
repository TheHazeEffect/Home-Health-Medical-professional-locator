using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeHealth.Data;
using HomeHealth.data.tables;
using HomeHealth.Entities;

namespace HomeHealth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly HomeHealthDbContext _context;

        public AppointmentsController(HomeHealthDbContext context)
        {
            _context = context;
        }

        // GET: api/Appointments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appointments>>> GetAppointment()
        {
            return await _context.Appointment.ToListAsync();
        }

        // GET: api/Appointments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Appointments>> GetAppointments(int id)
        {
            var appointments = await _context.Appointment.FindAsync(id);

            if (appointments == null)
            {
                return NotFound();
            }

            return appointments;
        }

        [HttpGet("profile/{id}")]
        public async Task<ActionResult<Appointments>> GetAppointments(string id)
        {

        
            var UserAppointments = await _context.Appointment
                .Include("Professional")
                .Include("Patient")
                .Include("Charges.Professional_Service.Service")
                .Where(A => A.PatientId == id || A.ProfessionalId == id)
                .Select( A => new AppointmentProfile {
                    AppointmentId = A.AppointmentId,
                    AppDate = A.AppDate,
                    AppTime = A.AppTime,
                    AppReason = A.AppReason,
                    PersonId = A.ProfessionalId == id ? A.PatientId :  A.ProfessionalId,
                    PersonFirstName = A.ProfessionalId == id ? A.Patient.FirstName :  A.Professional.FirstName,
                    PersonLastName = A.ProfessionalId == id ? A.Patient.LastName :  A.Professional.LastName,
                    totalcost = A.totalcost,
                    Charges = A.Charges.Select( C => new  AppointmentProfileCharge {
                            ChargeId = C.ChargeId,
                            serviceCost = (float)C.serviceCost,
                            ServiceName = C.Professional_Service.Service.ServiceName
                        }).ToList()

                }) 
                .ToListAsync();

            if (UserAppointments == null)
            {
                return NotFound( new { message = "No Appointments"});
            }

            return Ok(UserAppointments);
        }

        // PUT: api/Appointments/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointments(int id, Appointments appointments)
        {
            if (id != appointments.AppointmentId)
            {
                return BadRequest();
            }

            _context.Entry(appointments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppointmentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Appointments
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Appointments>> PostAppointments(Appointments appointments)
        {

            try {

                _context.Appointment.Add(appointments);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Appointment Scheduled", appointments});

            }catch(Exception ex) {
                    Console.WriteLine(ex);
                    return BadRequest(new { message = "Oop Something went wrong", appointments});

            }
            


        }

        [HttpPost("transaction")]
        public async Task<ActionResult<Appointments>> MakeAppointment(AppTransaction Transaction)
        {
             var newAppointment = new Appointments {
                    AppDate = Transaction.AppDate,
                    AppTime = Transaction.AppTime,
                    AppReason = Transaction.AppReason,
                    PatientId = Transaction.PatientId,
                    ProfessionalId = Transaction.ProfessionalId,
                    totalcost = 0
                };

            try {

                var SelectedServices = await _context.Professional_Service
                    .Where( PS => Transaction.ServiceList.Contains(PS.Professional_ServiceId))
                    .ToListAsync();

                var newCharges = new HashSet<Charges>();
                foreach (var item in SelectedServices)
                {
                    var charge = new Charges {
                        Prof_serviceId = item.Professional_ServiceId,
                        serviceCost = item.ServiceCost
                    };

                    newAppointment.totalcost += (float)item.ServiceCost;
                    newCharges.Add(charge);
                }

                newAppointment.Charges = newCharges;

                _context.Appointment.Add(newAppointment);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Appointment Scheduled", newAppointment});

            }catch(Exception ex) {
                    Console.WriteLine(ex);
                    return BadRequest(new { message = "Oop Something went wrong", newAppointment});

            }
        
        }

        // DELETE: api/Appointments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Appointments>> DeleteAppointments(int id)
        {
            var appointments = await _context.Appointment.FindAsync(id);
            if (appointments == null)
            {
                return NotFound();
            }

            _context.Appointment.Remove(appointments);
            await _context.SaveChangesAsync();

            return appointments;
        }

        private bool AppointmentsExists(int id)
        {
            return _context.Appointment.Any(e => e.AppointmentId == id);
        }
    }
}
