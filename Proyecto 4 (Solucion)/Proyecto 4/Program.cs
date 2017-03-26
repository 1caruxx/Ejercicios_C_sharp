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
            int suma = 0;
            int contadorDeNumerosPerfectos = 0;
            int contador = 1;
            int subContador = 1;

            Console.Title = "Ejercicio Nro. #04";

            Console.WriteLine("Los primeros 4 numeros perfectos son:");

            while(contadorDeNumerosPerfectos < 4)
            {
                if(subContador<contador)
                {
                    if(contador % subContador == 0)
                    {
                        suma += subContador;

                        if (suma == contador)
                        {
                            Console.WriteLine(contador);
                            contadorDeNumerosPerfectos++;
                            suma = 0;
                            continue;
                        }

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

            Console.ReadLine();
        }
    }
}
