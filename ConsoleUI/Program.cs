using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car classic = new Car() { HasTrunk = true, Make = "Chevrolet", Model = "Classic", Year = 2004 };
            Motorcycle harley = new Motorcycle() { HasSideCart = true, Make = "Harley Davidson", Model = "XR750", Year = 2015 };
            Vehicle golfCart = new Car() { HasTrunk = true, Make = "Yamaha", Model = "Drive", Year = 2009 };
            Vehicle goKart = new Car() { HasTrunk = false, Make = "Kandy", Model = "150cc", Year = 2020 };


            //Add the 4 vehicles to the list

            vehicles.Add(classic);
            vehicles.Add(harley);
            vehicles.Add(golfCart);
            vehicles.Add(goKart);

            // Using a foreach loop iterate over each of the properties


            // Call each of the drive methods for one car and one motorcycle

            Console.ReadLine();
        }
    }
}
