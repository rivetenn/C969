﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C969
{
    public class CustomerData
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }

        public int? CustId { get; set; }


        public CustomerData(string name, string address1, string phone, string city, string country, string postalCode, string address2)
        {
            CheckIfEmpty(new string[] { name, address1, phone });

            phone = CheckP(phone);

            Name = name.Trim();
            Address = address1.Trim();
            Phone = phone.Trim();
            City = Isempty(city);
            Country = Isempty(country);
            PostalCode = Isempty(postalCode);
            Address2 = Isempty(address2);
        }

        public string Isempty(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? "N/A" : value.Trim();
        }
        

        public static string CheckP(string phone)
        {
            foreach (char x in phone)
            {
                if (!char.IsDigit(x) && x != '-')
                {
                    throw new ArgumentException("Invalid Phone Number");
                }
            }

            string digitsOnly = new string(phone.Where(char.IsDigit).ToArray());

            if (digitsOnly.Length == 7)
            {
                return $"{digitsOnly.Substring(0, 3)}-{digitsOnly.Substring(3)}";
            }
            else if (digitsOnly.Length == 10)
            {
                return $"{digitsOnly.Substring(0, 3)}-{digitsOnly.Substring(3, 3)}-{digitsOnly.Substring(6)}";
            }
            else if (digitsOnly.Length == 11 && digitsOnly.StartsWith("1"))
            {
                return $"{digitsOnly.Substring(0, 1)}-{digitsOnly.Substring(1, 3)}-{digitsOnly.Substring(4, 3)}-{digitsOnly.Substring(7)}";
            }
            else
            {
                throw new Exception("Phone Number not valid. It must be 7, 10 or 11 digits.");
            }
        }
        private static void CheckIfEmpty(string[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("Invalid Input");
            foreach (var value in values)
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Missing Input");
                }
                
            }
        }
    }
}
