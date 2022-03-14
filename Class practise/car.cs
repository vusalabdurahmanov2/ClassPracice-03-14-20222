using System;
using System.Collections.Generic;
using System.Text;
using Class_practise;

namespace Class_practise
{
    internal class car:vehicle

    {
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
        public string brand;
        public string model;

        public car(int year,string brand, string model, double CurrentFuel, double FuelFor1Km, double FuelCapacity) : base(year)
        {
           this.brand = brand;
           this.model = model;
           this.CurrentFuel = CurrentFuel;
           this.FuelFor1Km = FuelFor1Km;
           this.FuelCapacity = FuelCapacity;
        }
        public void Drive(double km)
        {
            double drive = (FuelCapacity - CurrentFuel)/FuelFor1Km;

            if (drive >= km) Console.WriteLine($"You can drive car without adding any fuel\nYou have extra fuel:{drive - km}"); else Console.WriteLine($"You can't drive car with current fuel please add fuel to contiuniu: {km-drive}litr");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Car Brand:{brand}\nCar Model:{model}\nCar year:{year}\nCar fuel capacity:{FuelCapacity}\nCurrentFuel:{CurrentFuel}\nFuel for 1 Km:{FuelFor1Km}");
        }

    }
}
