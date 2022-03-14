using System;
using Class_practise.models;
namespace Class_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle car2 = new vehicle(13, "yasil");
            car car1 = new car("ay", "asd",50, 1,100) ;
            car1.Drive(599);
            
        }
    }
}
