using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            ZupaGrzybowa zupa = new ZupaGrzybowa();

            Console.WriteLine($"{zupa.Grzyby}");
            Console.WriteLine($"{zupa.Grzyby}");
            Console.WriteLine($"{zupa.Wywar}");

            zupa.Ugotuj();

        }
    }
}
