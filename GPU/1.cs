using System;

namespace ConsoleApp20
{
    class Program
    {
       static void Main(string[] args)
        {
            Gpu gpu = new Gpu();

            Console.WriteLine($"{gpu.Name}");
            Console.WriteLine($"{gpu.Color}");
            Console.WriteLine($"{gpu.price}");
            Console.WriteLine($"{gpu.RAM}");
            Console.WriteLine();
            Console.WriteLine($"Czy karata graficzna RTX3070 jest dostępna na x-kom lub morele? {gpu.dostepnosc}");
        }

    }
}
