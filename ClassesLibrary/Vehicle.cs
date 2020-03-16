using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public float Weight { get; set; }

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public Vehicle()
        {

        }

        public override string ToString()
        {
            return string.Format("\n==== VEHICLE ====\n\nMake: {0}\nModel: {1}\nYear: {2}\nWeight: {3:F}\n", Make, Model, Year, Weight);
        }
    }
}
