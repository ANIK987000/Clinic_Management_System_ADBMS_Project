﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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


        public List<Admin> GetAllAdmins()
        {
            string sql = "SELECT * FROM Admin";
            OracleDataReader reader = DbAccess.GetData(sql);
            List<Admin> admins = new List<Admin>();
            while (reader.Read())
            {
                Admin admin = new Admin();
                admin.AdminId = (int)reader["AdminId"];
                admin.AdminName = reader["AdminName"].ToString();
                admin.UserName = reader["Username"].ToString();
                admin.Password = reader["Password"].ToString();
                admin.Email = reader["Email"].ToString();
                admin.Gender = reader["Gender"].ToString();
                admin.Age = (int)reader["Age"];


                admins.Add(admin);
            }
            return admins;
        }
    }
}
