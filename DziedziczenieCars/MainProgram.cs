using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Suv suv = new Suv();

            suv.NumberOfdoors = 4;
            suv.NumberOfSeats = 5;
            suv.Engine = "Diesel";


            Console.WriteLine($"Ten sum ma {suv.NumberOfdoors} drzwi");
            Console.WriteLine($"Ten suv ma {suv.NumberOfSeats} siedzeń");
            Console.WriteLine($"Ten suv ma silnik {suv.Engine}");

        }
    }
}
