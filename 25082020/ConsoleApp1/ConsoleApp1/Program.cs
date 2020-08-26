using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             int numero = 0;
             while (numero < 10)
             {
                 numero++;
                 Console.WriteLine(numero);

             }
             do
             {
                 Console.WriteLine(numero);

             } while (numero < 10);
             Console.WriteLine("Hello World!");
         */
            int intentos = 0;
            int numero = 2;
            while (numero != 2 && intentos < 4);
            {
                Console.WriteLine("ingrese numero del 1 al 3");
                numero =int.Parse(Console.ReadLine());
                Console.WriteLine("bien");
                intentos++;
               
            }
            Console.WriteLine("Hello World!");
        }
    }
}
