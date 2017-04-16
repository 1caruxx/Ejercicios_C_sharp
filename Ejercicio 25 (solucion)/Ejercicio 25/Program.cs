using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. #25";

            int[] vector;
            string entrada;

            vector = new int[5];

            for(int contador=0 ; contador<5 ; contador++)
            {
                Console.WriteLine("Ingrese un numero (tiene que ser != 0)[{0}/5]",contador+1);
                entrada = Console.ReadLine();

                while(entrada == "0")
                {
                    Console.WriteLine("Error, reingre...");
                    entrada = Console.ReadLine();
                }

                int.TryParse(entrada , out vector[contador]);
            }

            Vector.mostrar(vector, 5);
            Console.Write("\n");
            Vector.mostrarPositivos(vector , 5);
            Console.Write("\n");
            Vector.mostrarNegativos(vector , 5);
            Console.Write("\n");

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
