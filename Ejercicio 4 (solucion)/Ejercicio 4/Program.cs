using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. #04";

            int suma = 0;
            int contadorDeNumerosPerfectos = 0;
            int contador = 1;
            int subContador = 1;

            Console.WriteLine("Los primeros 4 numeros perfectos son:");

            while (contadorDeNumerosPerfectos < 4)
            {
                if (suma == contador && subContador == contador - 1)
                {
                    Console.WriteLine(contador);
                    contadorDeNumerosPerfectos++;
                    suma = 0;
                    subContador = 1;
                    contador++;
                    continue;
                }

                if (subContador < contador)
                {
                    if (contador % subContador == 0)
                    {
                        suma += subContador;
                        subContador++;
                    }
                    else
                        subContador++;
                }
                else
                {
                    contador++;
                    subContador = 1;
                    suma = 0;
                }

            }

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadLine();
        }
    }
}