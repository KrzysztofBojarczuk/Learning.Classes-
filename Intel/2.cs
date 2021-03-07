using System;

namespace Klasa5
{
     class Program
    {
        static void Main(string[] args)
        {
            Intel intel = new Intel();

            Console.WriteLine($"{intel.Cenna}");
            Console.WriteLine($"{intel.Rdzenie}");
            Console.WriteLine($"{intel.Model}");
            Console.WriteLine("Czy procesor Intel i7 jest dostępny?");
            Console.WriteLine($"{intel.Dostępność}");
        }
    }
}
