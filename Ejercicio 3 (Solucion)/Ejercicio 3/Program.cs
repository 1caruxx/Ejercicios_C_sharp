using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero = 0;
            int contador = 1;
            int subContador=1;

            Console.Title = "Ejercicio Nro. #03";

            Console.WriteLine("Ingrese un numero.");
            entrada = Console.ReadLine();

            while(!int.TryParse(entrada , out numero))
            {
                Console.WriteLine("Error, reingrese.");
                entrada = Console.ReadLine();
            }

            Console.WriteLine("Los numeros primos hasta el numero introducido son: ");

            while(contador<=numero)
            {
                if(subContador <= contador)
                {
                    if(contador%subContador != 0)
                    {
                        subContador++;
                    }
                    else
                    {
                        contador++;
                        subContador = 1;
                    }
                }
                if(subContador == (contador))
                {
                    Console.WriteLine(contador);
                    contador++;
                    subContador = 1;
                }
            }

            Console.ReadLine();
        }
    }
}
