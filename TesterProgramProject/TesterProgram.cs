using ClassesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TesterProgramProject
{
    public class TesterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Testing for Classes Library ======\n\n");

            Student s1 = new Student();
            s1.FirstName = "Tony";
            s1.LastName = "Stark";
            s1.Id = "54321";
            s1.GPA = 4.0F;

            Student s2 = new Student();
            s2.FirstName = "Steve";
            s2.LastName = "Rogers";
            s2.Id = "12345";
            s2.GPA = 3.95F;

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Vehicle v1 = new Vehicle();
            v1.Make = "Honda";
            v1.Model = "Civic";
            v1.Year = 2012;
            v1.Weight = 25450f;

            Console.WriteLine(v1);

            Login l1 = new Login();
            l1.Username = "Avengers";
            l1.Password = "password";

            Console.WriteLine(l1);

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "1400 Veterans United Drive";
            c1.City = "Columbia";
            c1.State = "MO";
            c1.Zip = "65203";
            c1.Phone = "800-814-1103";
            c1.Email = "info@vu.com";

            Console.WriteLine(c1);

            Customer cu1 = new Customer();
            cu1.CustomerId = "1234";
            cu1.FirstName = "Ron";
            cu1.LastName = "Swanson";
            cu1.ContactInformation = c1;

            Console.WriteLine(cu1);

            CreditCardAccount cc1 = new CreditCardAccount();
            cc1.AccountNumber = 1234;
            cc1.CustomerInfo = cu1;
            cc1.Balance = 125.56m;
            cc1.IsPastDue = false;
            cc1.AnnualInterestRate = 0.05m;

            Console.WriteLine(cc1);

            Book bk1 = new Book();
            bk1.Title = "Where the Red Fern Grows";
            bk1.Author = "Blue";
            bk1.NbrOfPages = 325;

            Book bk2 = new Book("How to Get People to Like You", "Ryan Burton", 450);

            Console.WriteLine(bk1);
            Console.WriteLine(bk2);


            Library lb1 = new Library();
            lb1.Books = new List<Book>() { bk1, bk2 };
            lb1.LibraryName = "Columbia Public Library";
            lb1.StreetAddress = "1400 Broadway";
            lb1.City = "Columbia";
            lb1.State = "MO";
            lb1.Zip = "65203";

            Console.WriteLine(lb1);

            Song sg1 = new Song("Mariah Carey", "Always Be My Baby", 150);
            Song sg2 = new Song("Mariah Carey", "Daydream", 150);
            Song sg3 = new Song("Mariah Carey", "When I Saw You", 150);


            Console.WriteLine(sg1);

            Song[] cd1tracks = { sg1, sg2, sg3 };
  
            CD cd1 = new CD(cd1tracks, "Daydream", "Pop");
            Console.WriteLine(cd1);

            MotorHome m1 = new MotorHome("Winnie", "RR", 1995, 2000, 4);
            Console.WriteLine(m1);

            Truck t1 = new Truck("Ford", "F150", 2005, 35000, 225.50f);
            Console.WriteLine(t1);


        }
    }
}
