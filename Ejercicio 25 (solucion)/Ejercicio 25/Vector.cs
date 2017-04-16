using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25
{
    class Vector
    {
        public static void mostrar(int[] vector , int cantidad)
        {
            for(int contador=0 ; contador<cantidad ; contador++)
            {
                Console.Write(vector[contador] + " ");
            }
        }

        public static void mostrarPositivos(int[] vector, int cantidad)
        {
            int auxiliar;

            for (int contador=0 ; contador<cantidad-1 ; contador++)
            {
                for(int subContador=contador+1 ; subContador<cantidad ; subContador++)
                {
                    if(vector[contador] > vector[subContador])
                    {
                        auxiliar = vector[contador];
                        vector[contador] = vector[subContador];
                        vector[subContador] = auxiliar;
                    }
                }
            }
            for (int contador = 0; contador < cantidad; contador++)
            {
                if(vector[contador]>0)
                {
                    Console.Write(vector[contador] + " ");
                }
            }
        }

        public static void mostrarNegativos(int[] vector, int cantidad)
        {
            int auxiliar;

            for (int contador = 0; contador < cantidad - 1; contador++)
            {
                for (int subContador = contador + 1; subContador < cantidad; subContador++)
                {
                    if (vector[contador] < vector[subContador])
                    {
                        auxiliar = vector[contador];
                        vector[contador] = vector[subContador];
                        vector[subContador] = auxiliar;
                    }
                }
            }
            for (int contador = 0; contador < cantidad; contador++)
            {
                if (vector[contador] < 0)
                {
                    Console.Write(vector[contador] + " ");
                }
            }
        }
    }
}
