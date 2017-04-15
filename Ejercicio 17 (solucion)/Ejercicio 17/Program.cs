using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. #17";

            cuenta miCuenta;

            miCuenta = new cuenta();
            miCuenta.getNombre("fernando lareu");
            miCuenta.getNumeroDeCuenta("3098");
            miCuenta.getSaldo("25000,00");
            miCuenta.getTipoDeInteres("2");

        }
    }
}
