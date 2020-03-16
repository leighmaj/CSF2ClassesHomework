using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public ContactInfo()
        {

        }

        public override string ToString()
        {
            return string.Format("\n===== CONTACT INFO =====\n\nStreet Address: {0}\nCity: {1}\nState: {2}\n" +
                "Zip: {3}\nPhone: {4}\nEmail: {5}\n", StreetAddress, City, State, Zip, Phone, Email);
        }
    }
}
