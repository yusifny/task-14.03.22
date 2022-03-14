using System;
using vehicleClass.Models;

namespace vehicleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Car = new Car("Brand", "Model", 68, 2, 50, "Nardo Grey", 2019);

            //Car.Brand = "BMW";
            //Car.Model = "M5";
            //Car.FuelCapacity = 68;
            //Car.FuelFor1Km = 2;
            //Car.CurrentFuel = 50;
            //Car.Color = "Nardo Grey";
            //Car.Year = 2019;

            Car.ShowInfo();

            Car.Drive();

        }
    }
}
