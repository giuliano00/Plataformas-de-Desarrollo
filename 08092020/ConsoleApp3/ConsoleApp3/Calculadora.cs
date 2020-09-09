using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Calculadora : CalculadoraBase
    {

        public int sumar(int numero1,int numero2)
        {
            return numero1 + numero2;
        }
        public int restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public int dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

    }
}
