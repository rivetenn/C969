using System;
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


        public CustomerData(string name, string address1, string phone, string city = "", string country = "", string postalCode = "", string address2 = "")
        {
            CheckIfEmpty(new string[] { name, address1, phone });
            phone = CheckP(phone);
            Name = name.Trim();
            Address = address1.Trim();
            Phone = phone.Trim();
            City = city.Trim();
            Country = country.Trim();
            PostalCode = postalCode.Trim();
            Address2 = address2.Trim();
        }



        private static string CheckP(string phone)
        {
            int countN = 0;
            int countD = 0;
            foreach (char c in phone)
            {
                if (char.IsDigit(c))
                {
                    countN++;
                }
                else if (c == '-')
                {
                    countD++;
                }
                else
                {
                    throw new Exception("Invalid Phone Number");
                }
            }
            if (countN != 7 || countD > 1 || (countD == 1 && phone[3] != '-'))
            {
                throw new Exception("Invalid Phone Number");
            }
            if (countD == 0)
            {
                phone = phone.Insert(3, "-");
            }

            return phone;
        }
        private static void CheckIfEmpty(string[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("Invalid Input");
            foreach (var value in values)
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Input");
                }
            }
        }
    }
}
