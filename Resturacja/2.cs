using System;

namespace Klasa4
{
    class Program
    {
        static void Main(string[] args)
        {
            Resturacja resturacja = new Resturacja();

            resturacja.Menu = 10;
            resturacja.Miasto = "Koszalin";


            Console.WriteLine($"Ilość menu to {resturacja.Menu}");
            Console.WriteLine($"{resturacja.Miasto}");
            Console.WriteLine($"{resturacja.DlaUbogich}");
        }
    }
}
