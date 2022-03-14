using System;
using Class_practise;
namespace Class_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car(1999,"ay", "asd",50,0.1,100) ;
            car1.Drive(10);
            car1.ShowInfo();
        }
    }
}
