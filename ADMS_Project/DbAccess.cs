using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS_Project
{
    class DbAccess
    {
        private const string ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User ID=TIGER;Password=123;";
        private static OracleConnection _con;

        public static OracleConnection Connection
        {
            get
            {
                if (_con == null)
                {
                    _con = new OracleConnection(ConnectionString);
                }

                if (_con != null && _con.State == ConnectionState.Closed)
                {
                    _con.Open();
                }

                return _con;
            }
        }

        public static OracleDataReader GetData(string command)
        {
            OracleCommand cmd = new OracleCommand(command, Connection);
            OracleDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public static int UpdateDeleteInsert(string command)
        {
            OracleCommand cmd = new OracleCommand(command, Connection);
            return cmd.ExecuteNonQuery();
        }


        //_______________________Add Operation_______________________

        public static int addadmin(string a, string b, string c, string d, string e, int f)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "addadmin";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Varchar2).Value = a;
            objCmd.Parameters.Add("b", OracleDbType.Varchar2).Value = b;
            objCmd.Parameters.Add("c", OracleDbType.Varchar2).Value = c;
            objCmd.Parameters.Add("d", OracleDbType.Varchar2).Value = d;
            objCmd.Parameters.Add("e", OracleDbType.Varchar2).Value = e;
            objCmd.Parameters.Add("f", OracleDbType.Int32).Value = f;
            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }


        //______________________________________________

        public static int adddoctor(string a, string b, string c, string d, string e, string f,string g,int h,int i)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "adddoctor";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Varchar2).Value = a;
            objCmd.Parameters.Add("b", OracleDbType.Varchar2).Value = b;
            objCmd.Parameters.Add("c", OracleDbType.Varchar2).Value = c;
            objCmd.Parameters.Add("d", OracleDbType.Varchar2).Value = d;
            objCmd.Parameters.Add("e", OracleDbType.Varchar2).Value = e;
            objCmd.Parameters.Add("f", OracleDbType.Varchar2).Value = f;
            objCmd.Parameters.Add("g", OracleDbType.Varchar2).Value = g;
            objCmd.Parameters.Add("h", OracleDbType.Int32).Value = h;
            objCmd.Parameters.Add("i", OracleDbType.Int32).Value = i;
            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }

        //_________________________________________

        public static int addpatient(string a, string b, string c, string d, int e, int f, int g, string h, string i)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "addpatient";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Varchar2).Value =a ;
            objCmd.Parameters.Add("b", OracleDbType.Varchar2).Value = b;
            objCmd.Parameters.Add("c", OracleDbType.Varchar2).Value = c;
            objCmd.Parameters.Add("d", OracleDbType.Varchar2).Value = d;
            objCmd.Parameters.Add("e", OracleDbType.Int16).Value = e;
            objCmd.Parameters.Add("f", OracleDbType.Int16).Value = f;
            objCmd.Parameters.Add("g", OracleDbType.Int16).Value = g;
            objCmd.Parameters.Add("h", OracleDbType.Varchar2).Value = h;
            objCmd.Parameters.Add("i", OracleDbType.Varchar2).Value = i;
            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }

        //__________________________________________________

        public static int addreceptionist(string a, string b, string c, string d, string e, int f,int g)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "addreceptionist";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Varchar2).Value = a;
            objCmd.Parameters.Add("b", OracleDbType.Varchar2).Value = b;
            objCmd.Parameters.Add("c", OracleDbType.Varchar2).Value = c;
            objCmd.Parameters.Add("d", OracleDbType.Varchar2).Value = d;
            objCmd.Parameters.Add("e", OracleDbType.Varchar2).Value = e;
            objCmd.Parameters.Add("f", OracleDbType.Int32).Value = f;
            objCmd.Parameters.Add("g", OracleDbType.Int32).Value = g;
            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }

        //_____________________________________________________

        public static int addappointment(int a, int b, string c, int d)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "addappointment";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("did", OracleDbType.Int32).Value = a;
            objCmd.Parameters.Add("pid", OracleDbType.Int32).Value = b;
            objCmd.Parameters.Add("adate", OracleDbType.Varchar2).Value = c;
            objCmd.Parameters.Add("rid", OracleDbType.Int32).Value = d;
          
            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }

        //_________________________________________

        public static int addtreatment(int a, string b, int c)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "addtreatment";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("pid", OracleDbType.Int32).Value = a;
            objCmd.Parameters.Add("pres", OracleDbType.Varchar2).Value = b;
            objCmd.Parameters.Add("did", OracleDbType.Int32).Value = c;
            
            
           

            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }

        //________________________Delete Operation________________________________

        public static int deletepatient(int a)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "patient_dml.deletepatient";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Int32).Value = a;
           




            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }

        //____________________________________________________


        public static int deletedoctor(int a)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "doctor_dml.deletedoctor";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Int32).Value = a;





            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }



        //____________________________________


        public static int deletereceptionist(int a)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "deletereceptionist";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Int32).Value = a;





            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }



        //___________________________________________


        public static int deleteappointment(int a)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "deleteappointment";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Int32).Value = a;





            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }

        //_________________________________________

        public static int deletetreatment(int a)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "deletetreatment";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Int32).Value = a;





            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }

        //__________________________Update Operation__________________________

        public static int updatetreatment(int a,string b)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "updatetreatment";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Int32).Value = a;
            objCmd.Parameters.Add("b", OracleDbType.Varchar2).Value = b;





            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }

        //_____________________________________________________

        public static int updateappointment(int a, string b)
        {
            //OracleCommand cmd = new OracleCommand(command, Connection);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = Connection;
            objCmd.CommandText = "updateappointment";
            objCmd.CommandType = CommandType.StoredProcedure;

            objCmd.Parameters.Add("a", OracleDbType.Int32).Value = a;
            objCmd.Parameters.Add("b", OracleDbType.Varchar2).Value = b;





            //objCmd.Parameters.Add("pout_count", OracleDbType.Int16).Direction = ParameterDirection.Output;

            return objCmd.ExecuteNonQuery();
        }


        //___________________________________Select Operation_________________________

        public List<Admin> GetAllAdmins()
        {
            string sql = "SELECT * FROM Admin";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Admin> admins = new List<Admin>();
            while (reader.Read())
            {
                Admin admin = new Admin();
                admin.AdminId = Convert.ToInt32(reader["AdminId"]);
                admin.AdminName = reader["AdminName"].ToString();
                admin.UserName = reader["Username"].ToString();
                admin.Password = reader["Password"].ToString();
                admin.Email = reader["Email"].ToString();
                admin.Gender = reader["Gender"].ToString();
                admin.Age = Convert.ToInt32(reader["Age"]);


                admins.Add(admin);
            }
            return admins;
        }


        //___________________________________________________________

        public List<Admin1> GetAllAdmins1()
        {
            string sql = "SELECT * FROM adminview";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Admin1> admins = new List<Admin1>();
            while (reader.Read())
            {
                Admin1 admin = new Admin1();
                admin.AdminId = Convert.ToInt32(reader["AdminId"]);
                admin.AdminName = reader["AdminName"].ToString();
                admin.UserName = reader["Username"].ToString();
                admin.Email = reader["Email"].ToString();
                admin.Gender = reader["Gender"].ToString();
                admin.Age = Convert.ToInt32(reader["Age"]);


                admins.Add(admin);
            }
            return admins;
        }

        //_________________________________________________________

        public List<Doctor> GetAllDoctors()
        {
            string sql = "SELECT * FROM Doctor";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Doctor> doctors = new List<Doctor>();
            while (reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.DoctorId = Convert.ToInt32(reader["DoctorId"]);
                doctor.DoctorName = reader["DoctorName"].ToString();
                doctor.Username = reader["Username"].ToString();
                doctor.Password = reader["Password"].ToString();
                doctor.Department = reader["Department"].ToString();
                doctor.ChamberNo = reader["ChamberNo"].ToString();
                doctor.VisitingDays = reader["VisitingDays"].ToString();
                doctor.VisitingHours = reader["VisitingHours"].ToString();
                doctor.AppointmentFee = Convert.ToInt32(reader["AppointmentFee"]);
                doctor.AdminId = Convert.ToInt32(reader["AdminId"]);
                doctors.Add(doctor);
            }
            return doctors;
        }

        //_______________________________________________________

        public List<Doctor1> GetAllDoctors1()
        {
            string sql = "SELECT * FROM doctorview";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Doctor1> doctors = new List<Doctor1>();
            while (reader.Read())
            {
                Doctor1 doctor = new Doctor1();
                doctor.DoctorId = Convert.ToInt32(reader["DoctorId"]);
                doctor.DoctorName = reader["DoctorName"].ToString();
                doctor.Username = reader["Username"].ToString();
                doctor.Department = reader["Department"].ToString();
                doctor.ChamberNo = reader["ChamberNo"].ToString();
                doctor.VisitingDays = reader["VisitingDays"].ToString();
                doctor.VisitingHours = reader["VisitingHours"].ToString();
                doctor.AppointmentFee = Convert.ToInt32(reader["AppointmentFee"]);
              
                doctors.Add(doctor);
            }
            return doctors;
        }


        //________________________________________________________

        public List<Receptionist> GetAllReceptionists()
        {
            string sql = "SELECT * FROM Receptionist";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Receptionist> receptionists = new List<Receptionist>();
            while (reader.Read())
            {
                Receptionist receptionist = new Receptionist();
                receptionist.ReceptionistId = Convert.ToInt32(reader["ReceptionistId"]);
                receptionist.ReceptionistName = reader["ReceptionistName"].ToString();
                receptionist.UserName = reader["Username"].ToString();
                receptionist.Password = reader["Password"].ToString();
                receptionist.Email = reader["Email"].ToString();
                receptionist.Gender = reader["Gender"].ToString();
                receptionist.Age = Convert.ToInt32(reader["Age"]);
                receptionist.AdminId = Convert.ToInt32(reader["AdminId"]);


                receptionists.Add(receptionist);
            }
            return receptionists;
        }

        //________________________________________________________

        public List<Receptionist1> GetAllReceptionists1()
        {
            string sql = "SELECT * FROM receptionistview";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Receptionist1> receptionists = new List<Receptionist1>();
            while (reader.Read())
            {
                Receptionist1 receptionist = new Receptionist1();
                receptionist.ReceptionistId = Convert.ToInt32(reader["ReceptionistId"]);
                receptionist.ReceptionistName = reader["ReceptionistName"].ToString();
                receptionist.UserName = reader["Username"].ToString();
                receptionist.Email = reader["Email"].ToString();
                receptionist.Gender = reader["Gender"].ToString();
                receptionist.Age = Convert.ToInt32(reader["Age"]);
             


                receptionists.Add(receptionist);
            }
            return receptionists;
        }

        //________________________________________________________

        public List<Treatment> ShowTreatment()
        {

            string sql = "SELECT* FROM Treatment";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Treatment> treatments = new List<Treatment>();
            while (reader.Read())
            {
                Treatment treatment = new Treatment();
                treatment.PrescriptionNo = Convert.ToInt32(reader["PrescriptionNo"]);
                treatment.PatientId = Convert.ToInt32(reader["PatientId"]);
                treatment.DoctorId = Convert.ToInt32(reader["DoctorId"]);

               // treatment.PatientName = reader["PatientName"].ToString();
               //treatment.DoctorName = reader["DoctorName"].ToString();
                treatment.Prescription = reader["Prescription"].ToString();

                treatments.Add(treatment);
            }
            return treatments;
        }

        //__________________________________________________


        public List<Patient> GetAllPatients()
        {
            string sql = "SELECT * FROM Patient";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Patient> patients = new List<Patient>();
            while (reader.Read())
            {
                Patient patient = new Patient();
                patient.PatientId = Convert.ToInt32(reader["PatientId"]);
                patient.PatientName = reader["PatientName"].ToString();
                patient.Username = reader["Username"].ToString();
                patient.Password = reader["Password"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.Age = Convert.ToInt32(reader["Age"]);
                patient.Height = Convert.ToInt32(reader["Height"]);
                patient.Weight = Convert.ToInt32(reader["Weight"]);
                patient.BloodGroup = reader["BloodGroup"].ToString();
                patient.Disease = reader["Disease"].ToString();
                patients.Add(patient);
            }
            return patients;
        }

        //_____________________________________________________

        public List<Patient1> GetAllPatients1()
        {
            string sql = "SELECT * FROM patientview";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Patient1> patients = new List<Patient1>();
            while (reader.Read())
            {
                Patient1 patient = new Patient1();
                patient.PatientId = Convert.ToInt32(reader["PatientId"]);
                patient.PatientName = reader["PatientName"].ToString();
                patient.Username = reader["Username"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.Age = Convert.ToInt32(reader["Age"]);
                patient.Height = Convert.ToInt32(reader["Height"]);
                patient.Weight = Convert.ToInt32(reader["Weight"]);
                patient.BloodGroup = reader["BloodGroup"].ToString();
                patient.Disease = reader["Disease"].ToString();
                patients.Add(patient);
            }
            return patients;
        }


        //___________________________________________________

        public List<PatientTreatment> GetPatientTreatment()
        {
            //string sql = "select distinct * from patient,treatment where treatment.patientid=patient.patientid ";
            string sql = "select * from treatmentview";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<PatientTreatment> patientTreatments = new List<PatientTreatment>();
            while (reader.Read())
            {
                PatientTreatment patientTreatment = new PatientTreatment();
                patientTreatment.PrescriptionNo = Convert.ToInt32(reader["PrescriptionNo"]);
                patientTreatment.PatientId = Convert.ToInt32(reader["PatientId"]);
                patientTreatment.DoctorId = Convert.ToInt32(reader["DoctorId"]);
                patientTreatment.DoctorName = reader["DoctorName"].ToString();
                patientTreatment.PatientName = reader["PatientName"].ToString();
                patientTreatment.Disease = reader["Disease"].ToString();
                patientTreatment.Prescription = reader["Prescription"].ToString();
                //patientTreatment.Username = reader["Username"].ToString();
                //patientTreatment.Password = reader["Password"].ToString();
                // patientTreatment.Gender = reader["Gender"].ToString();
                //patientTreatment.Age = Convert.ToInt32(reader["Age"]);
                //patientTreatment.Height = Convert.ToInt32(reader["Height"]);
                //patientTreatment.Weight = Convert.ToInt32(reader["Weight"]);
                //patientTreatment.BloodGroup = reader["BloodGroup"].ToString();
                //patientTreatment.Disease = reader["Disease"].ToString();

                //patientTreatment.Prescription = reader["Prescription"].ToString();
                //patientTreatment.PrescriptionNo = Convert.ToInt32(reader["PrescriptionNo"]);
                //patientTreatment.PatientId = Convert.ToInt32(reader["PatientId"]);
                //patientTreatment.DoctorId = Convert.ToInt32(reader["DoctorId"]);

                // treatment.PatientName = reader["PatientName"].ToString();
                //patientTreatment.DoctorName = reader["DoctorName"].ToString();

                patientTreatments.Add(patientTreatment);
            }
            return patientTreatments;
        }



        //__________________________________________________________


        public List<Appointment> ShowAppointment()
        {

            string sql = "SELECT * FROM appointment";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Appointment> appointments = new List<Appointment>();
            while (reader.Read())
            {
                Appointment appointment = new Appointment();
                appointment.AppointmentSerial = Convert.ToInt32(reader["AppointmentSerial"]);
                appointment.DoctorId = Convert.ToInt32(reader["DoctorId"]);
                appointment.PatientId = Convert.ToInt32(reader["PatientId"]);
                appointment.AppointmentDate = reader["AppointmentDate"].ToString();
                appointment.ReceptionistId = Convert.ToInt32(reader["ReceptionistId"]);

                appointments.Add(appointment);
            }
            return appointments;
        }


        //________________________________________________________

        public List<DoctorPatientAppointment> GetDoctorPaitentAppointment()
        {
            //string sql = "SELECT * FROM Doctor,patient,appointment where appointment.doctorid=doctor.doctorid and appointment.patientid=patient.patientid";
            string sql = "select * from appointmentview";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<DoctorPatientAppointment> doctorPatientAppointments = new List<DoctorPatientAppointment>();
            while (reader.Read())
            {
                DoctorPatientAppointment doctorPatientAppointment = new DoctorPatientAppointment();

                doctorPatientAppointment.AppointmentSerial = Convert.ToInt32(reader["AppointmentSerial"]);
                doctorPatientAppointment.PatientId = Convert.ToInt32(reader["PatientId"]);
                doctorPatientAppointment.DoctorId = Convert.ToInt32(reader["DoctorId"]);
                doctorPatientAppointment.DoctorName = reader["DoctorName"].ToString();
                doctorPatientAppointment.PatientName = reader["PatientName"].ToString();
                doctorPatientAppointment.AppointmentDate = reader["AppointmentDate"].ToString();

                //_________________________________

                //doctorPatientAppointment.AppointmentSerial = Convert.ToInt32(reader["AppointmentSerial"]);
                //doctorPatientAppointment.ADoctorId = Convert.ToInt32(reader["DoctorId"]);
                //doctorPatientAppointment.APatientId = Convert.ToInt32(reader["PatientId"]);
                //doctorPatientAppointment.AppointmentDate = reader["AppointmentDate"].ToString();
                //doctorPatientAppointment.ReceptionistId = Convert.ToInt32(reader["ReceptionistId"]);

                ////____________________________________


                //doctorPatientAppointment.DoctorId = Convert.ToInt32(reader["DoctorId"]);
                //doctorPatientAppointment.DoctorName = reader["DoctorName"].ToString();
                //doctorPatientAppointment.DUsername = reader["Username"].ToString();
                //doctorPatientAppointment.DPassword = reader["Password"].ToString();
                //doctorPatientAppointment.Department = reader["Department"].ToString();
                //doctorPatientAppointment.ChamberNo = reader["ChamberNo"].ToString();
                //doctorPatientAppointment.visitingDays = reader["VisitingDays"].ToString();
                //doctorPatientAppointment.VisitingHours = reader["VisitingHours"].ToString();
                //doctorPatientAppointment.AppointmentFee = Convert.ToInt32(reader["AppointmentFee"]);
                //doctorPatientAppointment.AdminId = Convert.ToInt32(reader["AdminId"]);


                ////__________________________________

                //doctorPatientAppointment.PatientId = Convert.ToInt32(reader["PatientId"]);
                //doctorPatientAppointment.PatientName = reader["PatientName"].ToString();
                //doctorPatientAppointment.PUsername = reader["Username"].ToString();
                //doctorPatientAppointment.PPassword = reader["Password"].ToString();
                //doctorPatientAppointment.Gender = reader["Gender"].ToString();
                //doctorPatientAppointment.Age = Convert.ToInt32(reader["Age"]);
                //doctorPatientAppointment.Height = Convert.ToInt32(reader["Height"]);
                //doctorPatientAppointment.Weight = Convert.ToInt32(reader["Weight"]);
                //doctorPatientAppointment.BloodGroup = reader["BloodGroup"].ToString();
                //doctorPatientAppointment.Disease = reader["Disease"].ToString();


                

                doctorPatientAppointments.Add(doctorPatientAppointment);
            }
            return doctorPatientAppointments;
        }




    }
}
