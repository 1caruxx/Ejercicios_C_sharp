using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class Calculo_de_area
    {
        public static double calcularCuadrado(double medida)
        {
            return medida*medida;
        }

        public static double calcularTriangulo(double baseDelTriangulo , double alturaDelTriangulo)
        {
            return (baseDelTriangulo * alturaDelTriangulo)/2;
        }

        public static double calcularCirculo(double radio)
        {
            return Math.PI * (radio*radio);
        }
    }
}
