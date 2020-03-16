using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        public int NumberOfBeds { get; set; }

        public MotorHome()
        {
                
        }
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) 
            : base (make, model, year, weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
            NumberOfBeds = numberOfBeds;
        }

        public override string ToString()
        {
            return string.Format("\n==== MOTOR HOME ====\n\nMake: {0}\nModel: {1}\nYear: {2}\nWeight: {3:F}\nNumber Of Beds: {4}\n", 
                Make, Model, Year, Weight, NumberOfBeds);
        }

    }
}
