namespace Samolot
{
    class Program
    {
        static void Main(string[] args)
        {
            Samolot samolot = new Samolot();
            samolot.Color = "Niebieskiego";
            samolot.Year = 1964;
            samolot.NumbersOfSeats = 300;
            
            Console.WriteLine("Jakiego koloru jest samolot?");
            Console.WriteLine("W którym roku został wyprodukowany samolot?");
            Console.WriteLine("Ile siedzień ma samolot?");
            Console.WriteLine();

            Console.WriteLine($"Samolot jest koloru {samolot.Color}");
            Console.WriteLine($"Samolot został wypodukowany w {samolot.Year} roku");
            Console.WriteLine($"Samolot ma {samolot.NumbersOfSeats} siedzeń");

        }
    }
}
