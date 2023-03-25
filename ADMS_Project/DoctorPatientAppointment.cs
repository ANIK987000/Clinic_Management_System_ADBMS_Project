using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMS_Project
{
    class DoctorPatientAppointment
    {

        public int AppointmentSerial { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string AppointmentDate { get; set; }


        //_________________________________________
        //public int AppointmentSerial { get; set; }

        //public int ADoctorId { get; set; }
        //public int APatientId { get; set; }

        //public string AppointmentDate { get; set; }

        //public int ReceptionistId { get; set; }


        //________________________________________

        //public int DoctorId { get; set; }
        //public string DoctorName { get; set; }
        //public string DUsername { get; set; }
        //public string DPassword { get; set; }

        //public string Department { get; set; }

        //public string ChamberNo { get; set; }
        //public string visitingDays { get; set; }
        //public string VisitingHours { get; set; }
        //public int AppointmentFee { get; set; }

        //public int AdminId { get; set; }
        //____________________________________________
        //public string PatientName { get; set; }
        //public int PatientId { get; set; }
        //public string PUsername { get; set; }
        //public string PPassword { get; set; }
        //public string Gender { get; set; }
        //public int Age { get; set; }
        //public double Height { get; set; }
        //public double Weight { get; set; }
        //public string BloodGroup { get; set; }
        //public string Disease { get; set; }

       
    }
}
