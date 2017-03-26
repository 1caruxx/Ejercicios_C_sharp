using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int año = 0;

            Console.Title = "Ejercicio Nro. #06";

            Console.WriteLine("Ingrese el numero de un año.");
            entrada = Console.ReadLine();

            while(!int.TryParse(entrada , out año))
            {
                Console.WriteLine("Error, reingrese.");
                entrada = Console.ReadLine();
            }

            if(año%4 == 0)
            {
                Console.WriteLine("El año introducido es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año introducido no es bisiesto.");
            }

            Console.ReadLine();

        }
    }
}
