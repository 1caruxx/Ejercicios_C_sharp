using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero = 0;
            int suma = 0;

            do
            {
                Console.WriteLine("Ingrese un numero.");
                entrada = Console.ReadLine();

                while (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Error, reingrese.");
                    entrada = Console.ReadLine();
                }

                suma += numero;

                Console.WriteLine("Desea continuar?");
            } while (Validar_respuesta.validaS_N());

            Console.WriteLine("La suma de los numero es: " + suma);

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
