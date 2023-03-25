
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMS_Project
{
    class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Department { get; set; }

        public string ChamberNo { get; set; }
        public string VisitingDays { get; set; }
        public string VisitingHours { get; set; }
        public int AppointmentFee { get; set; }
        public int AdminId { get; set; }

        //public string Prescription { get; private set; }
    }
}
