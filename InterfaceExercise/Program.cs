using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car = new Car { Make = "Honda", Model = "Accord", NumberOfDoors = 2, NumberOfWheels = 4, IsInsured = true, Color = "Red", Logo = "Letter H", NumberOfInvestors = 200 };
            Truck truck = new Truck { Make = "Dodge", Model = "Durango", NumberOfDoors = 2, NumberOfWheels = 4, IsInsured = true, Color = "Green", Logo = "A Ram", NumberOfInvestors = 150 };
            SUV suv = new SUV { Make = "Jeep", Model = "Grand Cherokee", NumberOfDoors = 4, NumberOfWheels = 4, IsInsured = false, Color = "Blue", Logo = "The word JEEP", NumberOfInvestors = 100 };

            List<IVehicle> vehicles = new List<IVehicle> { car, truck, suv };


            foreach (var vehicle in vehicles)
            {
                PrintProperties(vehicle);
                Console.WriteLine();
                Console.WriteLine();
            }
                            
        }
        public static void PrintProperties(IVehicle vehicles)
        {
            Console.WriteLine(vehicles.GetType());
            Console.WriteLine($"Vehicle make : {vehicles.Make}");
            Console.WriteLine($"Vehicle model : {vehicles.Model}");
            Console.WriteLine($"Vehicle number of doors : {vehicles.NumberOfDoors}");
            Console.WriteLine($"Vehicle number of wheels : {vehicles.NumberOfWheels}");
            Console.WriteLine($"Is this vehicle insured? : {vehicles.IsInsured}");
            Console.WriteLine($"Vehicle color : {vehicles.Color}");
            Console.WriteLine($"Vehicle logo : {vehicles.Logo}");
            Console.WriteLine($"Current number of inverstors : {vehicles.NumberOfInvestors}");
        }
    }
}
