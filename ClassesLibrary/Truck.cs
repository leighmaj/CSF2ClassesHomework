using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        public float LoadCapacityLbs { get; set; }

        public Truck(string make, string model, int year, float weight, float loadCapacityLbs)
            : base (make, model, year, weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
            LoadCapacityLbs = loadCapacityLbs;
        }

        public Truck()
        {

        }

        public override string ToString()
        {
            return string.Format("\n==== TRUCK ====\n\nMake: {0}\nModel: {1}\nYear: {2}\nWeight: {3:F}\nLoad Capacity (lbs): {4}\n",
                Make, Model, Year, Weight, LoadCapacityLbs);
        }
    }
}
