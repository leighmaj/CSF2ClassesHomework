using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Library()
        {

        }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            string bookList = "";

            foreach (Book b in Books)
            {
                bookList += b + "\n";
            }

            return string.Format("\n===== LIBRARY =====\n\nLibrary Name: {0}\nStreet Address: {1}\nCity, State, Zip: {2}, {3} {4}\nBooks:\n{5}\n",
                LibraryName,
                StreetAddress,
                City,
                State,
                Zip,
                bookList);

        }
    }
}
