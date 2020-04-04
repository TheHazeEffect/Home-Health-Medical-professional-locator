import React from 'react'
import Modal from 'react-bootstrap/Modal'
import { Appointmentform } from "./appointmentform";
import { FormHoc } from "../../../HOC/FormHoc";

import Button from 'react-bootstrap/Button'
import { LoadingSpinner } from "../../../components/LoadingSpinner";


export const MakeAppointment = ({
    show,
    setShow,
    profId,
    patientId,
    services
}) => {

    const endpoint = "/api/appointments"
    const initialAppointmentObj = {
        AppDate: "",
        AppTime: "",
        AppReason: "",
        ProfessionalId: profId,
        totalcost : 5000,
        PatientId : patientId
    } 

    const formcomp = ({handleSubmit,Loading}) => {

      return <>

        <Appointmentform/>
        {
          Loading === true ?
          <Button 
            className="prof-button"
            variant="primary" 
            type="submit"
            onClick={ (e)=> e.preventDefault()}
                  >
              <LoadingSpinner 
                Show={Loading}
              />
            </Button>
          :
          <Button 
            className="prof-button"
            variant="primary" 
            type="submit"
            onClick={handleSubmit}>
              Submit Appointment
          </Button>
        }
          <Button 
            className="prof-button"
            variant="danger" 
            onClick={() => setShow(false)}>Cancel
        </Button>
      </>
    }

    return (
        <>
           <Modal show={show} >
              <Modal.Dialog>
                <Modal.Header >
                    <Modal.Title> Make an Appointment</Modal.Title>
                </Modal.Header>

               <Modal.Body>

              {

                FormHoc(endpoint,formcomp,initialAppointmentObj,

                )
              }

              </Modal.Body>
              <Modal.Footer>
                
              
              </Modal.Footer>
            </Modal.Dialog>
          </Modal>

        </>

    );
}