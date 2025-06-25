using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace C969
{
    public class SQLStuff
    {

        static string MSQL = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;

        public static BindingList<CustomerData> DataHolder = new BindingList<CustomerData>();

        private static string? WhoL;
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
                if (exists)
                {
                    WhoL = user;
                }
                con.Close();
                return exists;
            }
        }

        public static void UpdateDataH()
        {
            DataHolder.Clear();
            string SQLq = @"SELECT c.customerId, c.customerName, a.address, a.address2, a.postalCode, a.phone, ci.city, co.country
                FROM customer c
                JOIN address a ON c.addressId = a.addressId
                JOIN city ci ON a.cityId = ci.cityId
                JOIN country co ON ci.countryId = co.countryId";
            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(SQLq, con);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int custid = reader.GetInt32("customerId");
                        string name = reader.GetString("customerName");
                        string address = reader.GetString("address");
                        string phone = reader.GetString("phone");
                        string address2 = reader.GetString("address2");
                        string city = reader.GetString("city");
                        string country = reader.GetString("country");
                        string postal = reader.GetString("postalCode");

                        DataHolder.Add(new CustomerData(name, address, phone, city, country, postal, address2) { CustId = custid });
                    }
                }
            }
        }
        public static void AddCustomer(CustomerData obj)
        {
            string selectCountry = "SELECT countryId FROM country WHERE country = @country";
            string insertCountry = "INSERT INTO country (country, createDate, createdBy, lastUpdateBy) VALUES (@country, NOW(), @user, @user)";

            string selectCity = "SELECT cityId FROM city WHERE city = @city AND countryId = @countryId";
            string insertCity = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdateBy) VALUES (@city, @countryId, NOW(), @user, @user)";

            string insertAddress = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy) VALUES (@address, @address2, @cityId, @postal, @phone, NOW(), @user, @user)";
            string getLastId = "SELECT LAST_INSERT_ID()";

            string insertCustomer = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy) VALUES (@name, @addressId, 1, NOW(), @user, @user)";

            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                using (MySqlTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        int countryId;
                        using (var cmd = new MySqlCommand(selectCountry, con, tx))
                        {
                            cmd.Parameters.AddWithValue("@country", obj.Country);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                                countryId = Convert.ToInt32(result);
                            else
                            {
                                using (var insert = new MySqlCommand(insertCountry, con, tx))
                                {
                                    insert.Parameters.AddWithValue("@country", obj.Country);
                                    insert.Parameters.AddWithValue("@user", WhoL);
                                    insert.ExecuteNonQuery();
                                }
                                countryId = Convert.ToInt32(new MySqlCommand(getLastId, con, tx).ExecuteScalar());
                            }
                        }

                        int cityId;
                        using (var cmd = new MySqlCommand(selectCity, con, tx))
                        {
                            cmd.Parameters.AddWithValue("@city", obj.City);
                            cmd.Parameters.AddWithValue("@countryId", countryId);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                                cityId = Convert.ToInt32(result);
                            else
                            {
                                using (var insert = new MySqlCommand(insertCity, con, tx))
                                {
                                    insert.Parameters.AddWithValue("@city", obj.City);
                                    insert.Parameters.AddWithValue("@countryId", countryId);
                                    insert.Parameters.AddWithValue("@user", WhoL);
                                    insert.ExecuteNonQuery();
                                }
                                cityId = Convert.ToInt32(new MySqlCommand(getLastId, con, tx).ExecuteScalar());
                            }
                        }

                        int addressId;
                        using (var cmd = new MySqlCommand(insertAddress, con, tx))
                        {
                            cmd.Parameters.AddWithValue("@address", obj.Address);
                            cmd.Parameters.AddWithValue("@address2", obj.Address2);
                            cmd.Parameters.AddWithValue("@cityId", cityId);
                            cmd.Parameters.AddWithValue("@postal", obj.PostalCode);
                            cmd.Parameters.AddWithValue("@phone", obj.Phone);
                            cmd.Parameters.AddWithValue("@user", WhoL);
                            cmd.ExecuteNonQuery();
                            addressId = Convert.ToInt32(new MySqlCommand(getLastId, con, tx).ExecuteScalar());
                        }

                        using (var cmd = new MySqlCommand(insertCustomer, con, tx))
                        {
                            cmd.Parameters.AddWithValue("@name", obj.Name);
                            cmd.Parameters.AddWithValue("@addressId", addressId);
                            cmd.Parameters.AddWithValue("@user", WhoL);
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("Failed to add customer: " + ex.Message);
                    }
                }
            }
        }

        public static void DeleteCustomer(CustomerData obj)
        {
            if (obj.CustId == null) throw new Exception("Customer ID is null");
            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                using (MySqlTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        int addressId = 0;
                        string getAddressId = "SELECT addressId FROM customer WHERE customerId = @id";
                        using (var getth = new MySqlCommand(getAddressId, con, tx))
                        {
                            getth.Parameters.AddWithValue("@id", obj.CustId.Value);
                            var result = getth.ExecuteScalar();
                            addressId = Convert.ToInt32(result);
                        }
                        string deleteCustomer = "DELETE FROM customer WHERE customerId = @id";
                        using (var delq = new MySqlCommand(deleteCustomer, con, tx))
                        {
                            delq.Parameters.AddWithValue("@id", obj.CustId.Value);
                            delq.ExecuteNonQuery();
                        }
                        string deleteAddress = "DELETE FROM address WHERE addressId = @aid";
                        using (var delq = new MySqlCommand(deleteAddress, con, tx))
                        {
                            delq.Parameters.AddWithValue("@aid", addressId);
                            delq.ExecuteNonQuery();
                        }
                        tx.Commit();
                        UpdateDataH();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete customer: " + ex.Message);
                        tx.Rollback();
                        return;
                    }
                }
            }

        }

        public static void UpdateCustomer(CustomerData obj)
        {
            if (obj.CustId == null) throw new Exception("Customer ID is null");

            using (MySqlConnection con = new MySqlConnection(MSQL))
            {
                con.Open();
                using (MySqlTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        Debug.WriteLine("Updating customer: ");
                        string q = @"UPDATE customer 
                             SET customerName = @name, lastUpdateBy = @user, lastUpdate = NOW() 
                             WHERE customerId = @id";

                        using (var cmd = new MySqlCommand(q, con, tx))
                        {
                            cmd.Parameters.AddWithValue("@name", obj.Name);
                            cmd.Parameters.AddWithValue("@user", WhoL);
                            cmd.Parameters.AddWithValue("@id", obj.CustId);
                            Debug.WriteLine(obj.CustId.Value);
                            int affected = cmd.ExecuteNonQuery();
                            Debug.WriteLine($"Rows affected: {affected}");
                            Debug.WriteLine("Connected to DB: " + con.Database);
                            Debug.WriteLine($"New Name: {obj.Name}");
                        }

                        tx.Commit();
                        Debug.WriteLine("Finished");
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("Failed to update customer: " + ex.Message);
                        return;
                    }
                }
                UpdateDataH();
            }


        }


    }
}
