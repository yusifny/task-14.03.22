using System;
using System.Collections.Generic;
using System.Text;

namespace vehicleClass.Models
{
    internal class Vehicle 
    {
        public string Color;
        public int Year;

        public Vehicle(string Color, int Year)
        {
            this.Color = Color;
            this.Year = Year;
        }

        public void Drive()
        {

            Console.Write("Enter the distance (km): ");
            double Distance = Convert.ToDouble(Console.ReadLine());
            double Consumption = 2 * Distance;
            if (Distance <= 25)
            {
                
                double fuelLeft = 50 - Consumption;
                
                Console.WriteLine("You have enough gas to drive the distance.");
                Console.WriteLine("Press Enter for further information.");
                Console.ReadLine();
                Console.WriteLine($"ⓘ This trip requires {Consumption} liter gas.");
                Console.WriteLine($"ⓘ At the end of {Distance} KM, {fuelLeft} liter gas will remain.");
            }
            else
            {
                double gasFrac = Consumption - 50;
                Console.WriteLine($"ⓘ You don't have enough gas.");
                Console.WriteLine($"ⓘ { gasFrac} liter of additional gas is required to drive { Distance} km.");



            }
        }


    }
}
