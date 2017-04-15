using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_19.Clases;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. #19";
            Boligrafo boligrafoAzul;
            Boligrafo boligrafoRojo;
            int auxiliar;

            boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);

            boligrafoAzul.pintar(45);
            auxiliar = boligrafoAzul.getTinta();

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
