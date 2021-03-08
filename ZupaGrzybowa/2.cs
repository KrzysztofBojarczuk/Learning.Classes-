using System;
using System.Collections.Generic;
using System.Text;

namespace _6
{
    public class ZupaGrzybowa
    {
        public int Porcjewgramach { get; set; } = 100;
        public string Wywar { get; set; } = "kompot";
        public string Grzyby { get; set; } = "mieszanka suszonych grzybów";
        public void Ugotuj()
        {
            Console.WriteLine("Zua grzybowa jest gotowana");
        }
        public void Zjedz()
        {
            Console.WriteLine("Zupa grzybowa została zjedzona");
        }
    }
}
