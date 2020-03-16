using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        public Customer()
        {

        }

        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        public override string ToString()
        {
            return string.Format("\n===== CUSTOMER =====\n\nCustomerId: {0}\nFirst Name: {1}\nLast Name: {2}\nContact Information: {3}\n",
                CustomerId,
                FirstName,
                LastName,
                ContactInformation);
        }

    }
}
