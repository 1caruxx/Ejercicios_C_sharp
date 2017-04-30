using System;
//using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26.Cola
{
    class Cola
    {
        public static void mostrar(Queue vector)
        {
            foreach (int numerosrecorridos in vector)
            {
                Console.WriteLine(numerosrecorridos);
            }
        }
    }
}
