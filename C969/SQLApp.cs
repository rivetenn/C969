﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C969
{
    internal class SQLApp
    {
        static string MSQL = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;

        public static BindingList<AppTools> DataHolder = new BindingList<AppTools>();

        public static BindingList<AppTools> Dailyr = new BindingList<AppTools>();

        

        public static void UpdateDataH()
        {
            DataHolder.Clear();
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

                        DateTime start = DateTime.SpecifyKind(reader.GetDateTime("start"), DateTimeKind.Utc).ToLocalTime();
                        DateTime end = DateTime.SpecifyKind(reader.GetDateTime("end"), DateTimeKind.Utc).ToLocalTime();

                        DataHolder.Add(new AppTools(custid, userId, name, title, description, location, cont, type, start, end, url, appid));
                    }
                }
            }
        }

        public static void AddAppointment(AppTools app)
        {
            DateTime UTC = DateTime.UtcNow;
            string SQLq = @"INSERT INTO appointment 
        (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) 
        VALUES 
        (@custid, @userid, @title, @description, @location, @cont, @type, @url, @start, @end, @utc, @user, @utc, @user)";

            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                using (MySqlTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(SQLq, con, tx);
                        cmd.Parameters.AddWithValue("@custid", app.custid);
                        cmd.Parameters.AddWithValue("@userid", app.userid);
                        cmd.Parameters.AddWithValue("@title", app.title);
                        cmd.Parameters.AddWithValue("@description", app.description);
                        cmd.Parameters.AddWithValue("@location", app.location);
                        cmd.Parameters.AddWithValue("@cont", app.cont);
                        cmd.Parameters.AddWithValue("@type", app.type);
                        cmd.Parameters.AddWithValue("@url", app.url);
                        cmd.Parameters.AddWithValue("@start", app.start);
                        cmd.Parameters.AddWithValue("@end", app.end);
                        cmd.Parameters.AddWithValue("@user", SQLStuff.WhoL); 
                        cmd.Parameters.AddWithValue("@utc", UTC);

                        cmd.ExecuteNonQuery();
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("Failed to add appointment: " + ex.Message);
                    }
                }
            }
        }

        public static void DeleteAppointment(int appId)
        {
            string SQLq = "DELETE FROM appointment WHERE appointmentId = @id";

            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                using (MySqlTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(SQLq, con, tx))
                        {
                            Debug.WriteLine("Deleting appointment with ID: " + appId);
                            cmd.Parameters.AddWithValue("@id", appId);
                            cmd.ExecuteNonQuery();
                        }
                        tx.Commit();
                        UpdateDataH(); 
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("Failed: " + ex.Message);
                    }
                }
            }
        }

        public static void UpdateAppointment(AppTools app)
        {
            DateTime UTC = DateTime.UtcNow;
            string SQLq = @"UPDATE appointment SET customerId = @custid, userId = @userid, title = @title, description = @description, location = @location,
            contact = @cont, type = @type, url = @url, start = @start, end = @end, lastUpdate = @utc, lastUpdateBy = @user
        WHERE appointmentId = @appId";

            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                using (MySqlTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(SQLq, con, tx))
                        {
                            cmd.Parameters.AddWithValue("@custid", app.custid);
                            cmd.Parameters.AddWithValue("@userid", app.userid);
                            cmd.Parameters.AddWithValue("@title", app.title);
                            cmd.Parameters.AddWithValue("@description", app.description);
                            cmd.Parameters.AddWithValue("@location", app.location);
                            cmd.Parameters.AddWithValue("@cont", app.cont);
                            cmd.Parameters.AddWithValue("@type", app.type);
                            cmd.Parameters.AddWithValue("@url", app.url);
                            cmd.Parameters.AddWithValue("@start", app.start);
                            cmd.Parameters.AddWithValue("@end", app.end);
                            cmd.Parameters.AddWithValue("@user", SQLStuff.WhoL);
                            cmd.Parameters.AddWithValue("@appId", app.appID);
                            cmd.Parameters.AddWithValue("@utc", UTC);

                            cmd.ExecuteNonQuery();
                        }
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("Failed to update appointment: " + ex.Message);
                    }
                }
            }
        }

        public static bool CheckForApp(DateTime start, DateTime end, int? excludeAppId = null)
        {
            string query = @"
                SELECT COUNT(*) FROM appointment 
                WHERE ((start < @end AND end > @start))";

            if (excludeAppId.HasValue)
                query += " AND appointmentId != @excludeId";

            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    if (excludeAppId.HasValue)
                        cmd.Parameters.AddWithValue("@excludeId", excludeAppId.Value);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static void DateApps(DateTime start, DateTime end)
        {
            Dailyr.Clear();
            string SQLq = @"SELECT app.appointmentId, app.customerId, app.userId, app.title, app.description, app.location, app.url, app.contact, app.type, app.start, app.end, c.customerName
                    FROM appointment app
                    JOIN customer c ON app.customerId = c.customerId
                    WHERE app.start >= @start AND app.end <= @end";

            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(SQLq, con))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

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
                            DateTime s = reader.GetDateTime("start");
                            DateTime e = reader.GetDateTime("end");

                            Dailyr.Add(new AppTools(custid, userId, name, title, description, location, cont, type, s, e, url, appid));
                        }
                    }
                }
            }
        }
        public static void CheckFA()
        {
            string getUserIdQuery = "SELECT userId FROM user WHERE userName = @userName";
            string getAppointmentsQuery = "SELECT start FROM appointment WHERE userId = @userId";

            using (var con = new MySqlConnection(MSQL))
            {
                con.Open();

                int userId;
                using (var cmd = new MySqlCommand(getUserIdQuery, con))
                {
                    cmd.Parameters.AddWithValue("@userName", SQLStuff.WhoL);
                    userId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var cmd = new MySqlCommand(getAppointmentsQuery, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        DateTime nowLocal = DateTime.Now;
                        DateTime limitLocal = nowLocal.AddMinutes(15);

                        while (reader.Read())
                        {
                            DateTime utcStart = reader.GetDateTime("start");
                            DateTime localStart = utcStart.ToLocalTime();

                            if (localStart >= nowLocal && localStart <= limitLocal)
                            {
                                MessageBox.Show($"You have an appointment at {localStart:t}.",
                                                "Upcoming Appointment",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }

    }
}
