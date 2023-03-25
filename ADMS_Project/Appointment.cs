using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMS_Project
{
    class Appointment
    {
        public int AppointmentSerial { get; set; }
        public int DoctorId { get;  set; }
        public int PatientId { get;  set; }
      
        public string AppointmentDate { get; set; }

        public int ReceptionistId { get;  set; }
    }
}
