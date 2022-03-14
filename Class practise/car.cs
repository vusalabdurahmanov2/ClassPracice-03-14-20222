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
           this.brand = brand;this.model = model;this.CurrentFuel = CurrentFuel;this.FuelFor1Km = FuelFor1Km;this.FuelCapacity = FuelCapacity;
        }
        public car(int year,string color, string brand, string model, double CurrentFuel, double FuelFor1Km, double FuelCapacity) : base(year,color)
        {
            this.brand = brand;this.model = model;this.CurrentFuel = CurrentFuel;this.FuelFor1Km = FuelFor1Km;this.FuelCapacity = FuelCapacity;
        }
        public void Drive(double km)//km    
        {
            double drive = CurrentFuel/FuelFor1Km;
            if (CurrentFuel > FuelCapacity) Console.WriteLine($"Please decrase fuel value:{FuelCapacity- CurrentFuel}"); else if (drive >= km) Console.WriteLine($"You can drive car destination  without adding any fuel\nYou have extra fuel:{(drive - km)* FuelFor1Km }litr\nYou can drive extra:{(drive - km)}Km"); else Console.WriteLine($"You can't drive car with current fuel please add fuel to contiuniu: {(km-drive)* FuelFor1Km}litr");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Car Brand:{brand}\nCar Model:{model}\nCar Color{color}\nCar year:{year}\nCar fuel capacity:{FuelCapacity}\nCurrentFuel:{CurrentFuel}\nFuel for 1 Km:{FuelFor1Km}");
        }

    }
}
