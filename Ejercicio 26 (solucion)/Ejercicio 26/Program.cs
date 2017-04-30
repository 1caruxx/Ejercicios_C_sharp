using System;
using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. #26";

            Stack pila = new Stack();
            Queue cola = new Queue();

            pila.Push(67);
            pila.Push(45);
            pila.Push(1);

            foreach (int numerosrecorridos in pila)
            {
                Console.WriteLine(numerosrecorridos);
            }

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
