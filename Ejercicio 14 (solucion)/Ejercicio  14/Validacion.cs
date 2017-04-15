using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class Validacion
    {
        public static bool validar(int minimo, int numero, int maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
