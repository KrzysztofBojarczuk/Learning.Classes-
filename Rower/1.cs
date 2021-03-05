using System;

namespace Klasa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rower rower = new Rower();

            rower.ilośćkół = 2;
            rower.rodzaj = "góral";
            rower.siedzenie = 1;

            Console.WriteLine("Ile rower ma kół?");
            Console.WriteLine("Jaki to rodzaj roweru?");
            Console.WriteLine("Ile rower ma siedzeń?");
            Console.WriteLine();
            Console.WriteLine($"Rower ma kół {rower.ilośćkół}");
            Console.WriteLine($"Ten rodzaj roweru to {rower.rodzaj}");
            Console.WriteLine($"Ten rower ma siedzeń {rower.siedzenie}");
        }
    }
}
