﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeHealth.Web.Data.Tables
{
    public partial class Charges
    {
        public int ChargeId { get; set; }

        [Required]
        public int? AppointmentId { get; set; }

        [Required]
        public int? Prof_serviceId {get;set;}

        [Required]
        public float? serviceCost { get; set; }

        public virtual Appointments Appointment {get; set;}
        public virtual Professional_Service Professional_Service { get; set; }
    }
}
