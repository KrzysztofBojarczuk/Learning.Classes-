using System;

namespace Klasa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Człowiek człowiek = new Człowiek();

            //człowiek.Color = "Biały";
            //człowiek.Year = 1988;
            //człowiek.NumberOfLegs = 2;

            Console.WriteLine(człowiek.Color);
            Console.WriteLine(człowiek.Year);
            Console.WriteLine(człowiek.NumberOfLegs);
        }
    }
}
