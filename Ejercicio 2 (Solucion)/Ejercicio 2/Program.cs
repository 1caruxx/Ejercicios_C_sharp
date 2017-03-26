using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero=0;

            Console.Title = "Ejercicio Nro. #02";

            Console.WriteLine("Ingrese un numero (Debe ser > 0)");
            entrada = Console.ReadLine();

            while(!int.TryParse(entrada , out numero) || numero<=0)
            {
                Console.WriteLine("Error, reingresar.");
                entrada = Console.ReadLine();
            }

            Console.WriteLine("El cuadrado del numero ingresado es: " + Math.Pow(numero, 2));
            Console.WriteLine("El cubo del numero ingresado es: " + Math.Pow(numero, 3));

            Console.ReadKey();
        }
    }
}
