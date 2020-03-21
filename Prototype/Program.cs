using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
           var uno = new PopularCar();
           uno.Name = "Uno";
           uno.Color = "White";
           uno.Year = 1994;

           var mobi = (PopularCar)uno.Clone();
           mobi.Name = "Mobi";
           mobi.Year = 2020;


           Console.WriteLine(uno.ToString());
           
           Console.WriteLine(mobi.ToString());


        }
    }
}
