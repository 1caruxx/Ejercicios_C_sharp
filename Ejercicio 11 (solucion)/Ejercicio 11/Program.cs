using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero;
            int contador;
            int maximo = 0;
            int minimo = 0;
            int suma = 0;

            Console.Title = "Ejercicio Nro. 11";

            for(contador=0 ; contador<10 ; contador++)
            {
                Console.WriteLine("Ingrese un numero (entre -100 y 100 inclusive) [{0} /10].", contador+1);
                entrada = Console.ReadLine();

                while(!int.TryParse(entrada , out numero) || !Validacion.validar(-100 , numero , 100))
                {
                    Console.WriteLine("Error, reingese.");
                    entrada = Console.ReadLine();
                }

                if (contador == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if(numero > maximo)
                    {
                        maximo = numero;
                    }

                    if(numero < minimo)
                    {
                        minimo = numero;
                    }
                }

                suma += numero;

            }

            Console.WriteLine("El numero maximo introducido es: " + maximo);
            Console.WriteLine("El numero minimo introducido es: " + minimo);
            Console.WriteLine("El promedio de los numeros introducidos es: " + suma/10);

            Console.WriteLine("Pulse una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
