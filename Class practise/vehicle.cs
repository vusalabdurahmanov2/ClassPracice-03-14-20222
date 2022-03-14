using System;
using System.Collections.Generic;
using System.Text;

namespace Class_practise
{
    internal class vehicle
    {
        public string color;
        public int year;
        public vehicle(int year)
        {
            this.year = year;
        }
        public vehicle(int year, string color):this(year)
        {
            this.color = color; 
        }

    }
}
