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
        required public string Name { get; set; }
        required public string Address { get; set; }
        required public string Phone { get; set; }

       CustomerData(string name, string address, string phone)
        {
            try
            {
                phone = CheckP(phone);
                CheckIfEmpty(new string[] { name, address, phone });
                Name = name.Trim();
                Address = address.Trim();
                Phone = phone.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data");
            }
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
