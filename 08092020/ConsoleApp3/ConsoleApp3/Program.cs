using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculadora calculadora = new Calculadora();
            CalculadoraCientifica calculadoracientifica = new CalculadoraCientifica();
            CalculadoraBase calculadoraBase = new CalculadoraBase();

            Console.WriteLine(calculadora.dividir(10, 2));




        }
    }
}
