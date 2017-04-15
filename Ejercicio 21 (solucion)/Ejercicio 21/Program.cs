using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. #21";
            Euro.Euro euro = 2;
            Euro.Euro euro2 = 7;
            Dolar.Dolar dolar=1;

            euro += 5;
            euro += euro2;

            euro -= euro2;

            dolar = euro2;

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
