using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculadora calculadora = new Calculadora();
 
            Console.WriteLine(calculadora.dividir(10, 2));
            //--------------------------------------------------------------------------------
            CalculadoraCientifica calculadoracientifica = new CalculadoraCientifica();

            Console.WriteLine(calculadoracientifica.Potencia(2,4));

            //--------------------------------------------------------------------------------
            CalculadoraBase calculadoraBase = new CalculadoraBase();

            Console.WriteLine(calculadoraBase.Restar(2, 4));
        }
    }
}
