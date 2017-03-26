using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Validar_respuesta
    {
        public static bool validaS_N()
        {
            bool retorno=false;
            string entrada;

            entrada = Console.ReadLine();

            while (entrada!="s" && entrada!="S" && entrada!="n" && entrada!="N")
            {
                Console.WriteLine("Error, reingrese.");
                entrada = Console.ReadLine();
            }

            if (entrada=="s" || entrada=="S")
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
