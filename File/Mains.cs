using System;

namespace klasa7
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word();

            word.FileName = "Dokument";
            word.Size = 15;
            word.Print();

            Console.WriteLine($"Nazwa dokuemntu to {word.FileName}");
            word.Print();

            word.USA = "USA";
            Console.WriteLine($"{word.USA}");

        }
    }
}
