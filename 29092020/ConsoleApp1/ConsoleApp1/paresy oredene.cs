using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class paresy_oredene
    {
       List<int> listaDeNumeros = new List<int> { 1,2,3,4,5,6,7,8,9,10 };
         var numerosPar = listaDeNumeros.Where(n => n % 2 == 0).OrderByDescending(n => n);
         foreach (var n in numerosPar)
            {
                Console.WriteLine(n);
            }
    }
}
