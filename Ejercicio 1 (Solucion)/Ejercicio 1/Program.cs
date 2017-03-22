using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero;
            int contador;
            int suma=0;
            int maximo = 0;
            int minimo = 0;

            Console.Title = "Ejercicio nro. #01";

            for (contador=0;  contador <5 ; contador++)
            {
                Console.Clear();

                Console.WriteLine("Escriba un un numero [" + contador + "/4]");
                entrada = Console.ReadLine();

                while(!int.TryParse(entrada , out numero))
                {
                    Console.WriteLine("Dato ingresado no valido, reingrese.");
                    entrada = Console.ReadLine();
                }

                if(contador == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }

                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }
                suma += numero;
            }
            Console.WriteLine("El numero maximo ingresado es: " + maximo);
            Console.WriteLine("El numero minimo ingresado es: " + minimo);
            Console.WriteLine("El numero promedio es: " + suma/5);
            Console.ReadKey();
        }
    }
}
