using System;
//using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26.Pila
{
    class Pila
    {
        public static void mostrar(Stack vector)
        {
            foreach (int numerosrecorridos in vector)
            {
                Console.WriteLine(numerosrecorridos);
            }
        }

        public static void mostrarPositivos(Stack vector)
        {
            int auxiliar;
            int contador;

            foreach (int numerosRcorridos in vector)
            {
                foreach (int numerosRcorridos in vector)
                {


                }

            }

            for (int contador = 0; contador < cantidad - 1; contador++)
            {
                for (int subContador = contador + 1; subContador < cantidad; subContador++)
                {
                    if (vector[contador] > vector[subContador])
                    {
                        auxiliar = vector[contador];
                        vector[contador] = vector[subContador];
                        vector[subContador] = auxiliar;
                    }
                }
            }
            for (int contador = 0; contador < cantidad; contador++)
            {
                if (vector[contador] > 0)
                {
                    Console.Write(vector[contador] + " ");
                }
            }
        }
    }
}
