using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969
{
    public class CustomerData
    {
        required public string Name { get; set; }
        required public string Address { get; set; }
        required  public string PostalCode { get; set; }
        required public string Phone { get; set; }

       CustomerData(string name, string address, string postalCode, string phone)
        {
            try
            {
                Name = name.Trim();
                Address = address.Trim();
                PostalCode = postalCode.Trim();
                Phone = phone.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing CustomerData: {ex.Message}");
            }

        }
    }
}
