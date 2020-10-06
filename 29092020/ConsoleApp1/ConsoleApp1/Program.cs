using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] nombres = { "giu", "fede", "gis" };

            IEnumerable<string> conf = from nombres in nombres where nombres.StartsWith("f")select nombres;

            IEnumerable<string> conm = nombres.Where(i => i.StartsWith("f"));
            
            foreach(var item in conf)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
