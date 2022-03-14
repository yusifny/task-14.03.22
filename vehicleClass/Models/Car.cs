using System;
using System.Collections.Generic;
using System.Text;

namespace vehicleClass.Models
{
    internal class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(string Brand, string Model, double FuelCapacity, double FuelFor1Km, double CurrentFuel, string Color, int Year): base(Color, Year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;
            this.CurrentFuel = CurrentFuel;
            this.Color = Color;
            this.Year = Year;
          
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nFuel Capacity: {FuelCapacity}\nConsumption per 1 KM: {FuelFor1Km}\nCurrent Fuel: {CurrentFuel}\nColor: {Color}\nYear: {Year}");
        }


    }
}
