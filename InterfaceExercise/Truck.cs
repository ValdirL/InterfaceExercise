using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }

        //Inherited from IVehicle
        public bool IsInsured { get; set; }
        public string Color { get; set; }

        //Inherited from ICompany
        public string Logo { get; set; }
        public int NumberOfInvestors { get; set; }
    }
}
