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
    internal class ReportsLambda
    {
        static string MSQL = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;

        public static BindingList<AppTools> couldhavedonethisbetter = new BindingList<AppTools>();
        public static void UpdateDataH()
        {
            couldhavedonethisbetter.Clear();
            string SQLq = @"SELECT app.appointmentId, app.customerId, app.userId, app.title, app.description, app.location, app.url, app.contact, app.type, app.start, app.end, c.customerName
                FROM appointment app
                JOIN customer c ON app.customerId = c.customerId";
            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(SQLq, con);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int appid = reader.GetInt32("appointmentId");
                        int custid = reader.GetInt32("customerId");
                        int userId = reader.GetInt32("userId");
                        string name = reader.GetString("customerName");
                        string title = reader.GetString("title");
                        string description = reader.GetString("description");
                        string location = reader.GetString("location");
                        string cont = reader.GetString("contact");
                        string type = reader.GetString("type");
                        string url = reader.GetString("url");
                        DateTime start = reader.GetDateTime("start");
                        DateTime end = reader.GetDateTime("end");


                        couldhavedonethisbetter.Add(new AppTools(custid, userId, name, title, description, location, cont, type, start, end, url, appid));
                    }
                }
            }
        }
        public static List<object> MonthAndAll()
        {
            return couldhavedonethisbetter
                .GroupBy(app => new { Month = app.start.ToString("MMMM"), Type = app.type })
                .Select(g => new
                {
                    g.Key.Month,
                    g.Key.Type,
                    Count = g.Count()
                })
                .OrderBy(x => x.Month)
                .ThenBy(x => x.Type)
                .Cast<object>()
                .ToList();
        }

        public static List<string> GetAllUsers()
        {
            return SQLStuff.DataHolder
                .Select(x => x.Name)
                .Distinct()
                .OrderBy(x => x)
                .ToList();
        }

        public static List<object> UserApps(string username)
        {
            return couldhavedonethisbetter
                .Where(x => x.name == username)
                .Select(x => new
                {
                    x.title,
                    x.description,
                    x.location,
                    Start = x.start,
                    End = x.end
                })
                .Cast<object>()
                .ToList();
        }

        public static int Count()
        {
            return couldhavedonethisbetter
                .Count(x => x.start > DateTime.Now);
        }


    }
}
