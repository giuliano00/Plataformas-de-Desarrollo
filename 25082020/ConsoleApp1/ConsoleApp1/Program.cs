using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------------
            // clase 2
            //------------------------------------------------------------------------------
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
            /*
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
            */
            //------------------------------------------------------------------------------
            // clase 3
            //------------------------------------------------------------------------------
            /*int numeroSecreto;
            int respuesta;
            int maxIntentos = 3;

            Random random = new Random();
            numeroSecreto = random.Next(10);

            string mensaje = "";
            Console.WriteLine("Intenta adivinar el numero secreto \n");

            for (int i = 0; i < maxIntentos; i++)
            {
                respuesta = int.Parse(Console.ReadLine());
                mensaje = respuesta == numeroSecreto ? "Has Ganado" : "El numero no es correcto. Vuelve a intentar";
                if (respuesta == numeroSecreto)
                {
                    break;
                }

                if (i == maxIntentos - 1)
                {
                    mensaje = "Has perdido el numero era: " + numeroSecreto;
                    break;
                }
                Console.WriteLine(mensaje + "\n");
            }
            Console.WriteLine(mensaje + "\n");
            */
            //-----------------------------------------------------------------------------------
            /*
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el numero");
                string valor = Console.ReadLine();
                numero = int.Parse(valor);
                if (numero == secreto) break;
            }
            if (numero == secreto)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste el numero era " + secreto);
            }
            */

            //---------------------------------------------------------------
            /*
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el numero");
                string valor = Console.ReadLine();
                numero = int.Parse(valor);
                if (numero == secreto) break;
            }
            String mensaje;
            if (numero == secreto)
            {
                mensaje = Ganaste();
            }
            else
            {
                mensaje = Perdiste(secreto);
            }
            Console.WriteLine(mensaje);
            static string Ganaste()
            {
                string mensaje = "ganste";
                return mensaje;
            }

            static string Perdiste(int valor)
            {
                return "Perdiste" + valor;
            }
            */
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;

            for (int i = 0; i < 3; i++)
            {
                IngreseElNumero("ingrese el numero");
                if (numero == secreto) break;
            }
            String mensaje;

            if (numero == secreto)
            {
                mensaje = Ganaste();
            }
            else
            {
                mensaje = Perdiste(secreto);
            }
            Console.WriteLine(mensaje);

            static void IngreseElNumero(string mensaje,ref int numero)
            {
                Console.WriteLine(mensaje);
                string valor = Console.ReadLine();
                numero = int.Parse(valor);
            }
            
            static string Ganaste()
            {
                string mensaje = "ganste";
                return mensaje;
            }

            static string Perdiste(int valor)
            {
                return "Perdiste" + valor;
            }


        }
        
    }
}
