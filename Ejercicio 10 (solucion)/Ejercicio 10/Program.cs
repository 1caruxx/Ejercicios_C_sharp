using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. #10";

            string entrada;
            int numero;
            int contador = 0;
            int subcontador = -1;
            int espacios;

            Console.WriteLine("Ingrese un numero (Tiene que ser mayor >0).");
            entrada = Console.ReadLine();

            while(!int.TryParse(entrada , out numero))
            {
                Console.WriteLine("Error, reingrese...");
                entrada = Console.ReadLine();
            }

            espacios = numero;

            for(contador=0 ; contador<numero ; contador++)
            {
               
                for (espacios=numero-contador; espacios>0; espacios--)
                {
                    Console.Write(" ");
                }

                for(subcontador=-1; subcontador<contador; subcontador++)
                {
                    if(subcontador==-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("**");
                    }
                }
                Console.Write("\n");
            }

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
