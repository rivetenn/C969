using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace C969
{
    internal class SQLStuff
    {

        static string MSQL = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;

        public static BindingList<CustomerData> DataHolder = new BindingList<CustomerData>();
        public static bool CheckUser(string user, string pass)
        {
            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                string query = "SELECT * FROM user WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool exists = reader.HasRows;
                con.Close();
                return exists;
            }
        }

        public static bool AddCustomer;


    }
}
