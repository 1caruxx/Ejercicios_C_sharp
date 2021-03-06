﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. #09";

            string entrada;
            int altura = 0;
            int contador = 0;
            int subContador = -1;

            Console.WriteLine("Ingrese la altura de la piramide (tiene que ser >0).");
            entrada = Console.ReadLine();

            while(!int.TryParse(entrada , out altura) || altura<=0)
            {
                Console.WriteLine("Error, reingrese.");
                entrada = Console.ReadLine();
            }

            for(contador=0 ; contador<altura ; contador++)
            {
                for(subContador=-1 ; subContador<contador ; subContador++)
                {
                    if(subContador == -1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("**");
                    }
                    
                }
                Console.Write("\n");
                subContador = -1;
            }

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
