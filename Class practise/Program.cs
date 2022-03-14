using System;
using Class_practise;
namespace Class_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car(1999,"BmW","F90",50,0.1,400);
            car1.Drive(100);//input (km)
        }
    }
}
