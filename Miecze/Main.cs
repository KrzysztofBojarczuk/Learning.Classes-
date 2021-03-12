using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Samurajski samurajski = new Samurajski();
            Szabla szabla = new Szabla();


            Console.WriteLine($"Miecze zarówno samurajskie oraz szable muszą mieć {samurajski.Długość} cm długosć ");

            Console.WriteLine($"Miecz samurajsjki pochodzi {samurajski.Kraj}");

            Console.WriteLine($"Szabla jest {szabla.Prosty}");
            

        }
    }
}
