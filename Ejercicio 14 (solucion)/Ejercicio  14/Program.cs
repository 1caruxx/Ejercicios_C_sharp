using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 14";
            string entrada;
            int numero;
            double medida;
            double altura;

            Console.WriteLine("De que figura desea saber el area?");
            Console.WriteLine("1- Cuadrado.");
            Console.WriteLine("2- Triangulo.");
            Console.WriteLine("3- Circulo.");

            entrada = Console.ReadLine();

            while(!int.TryParse(entrada , out numero) || !Validacion.validar(1 , numero , 3))
            {
                Console.WriteLine("Error, reingrese.");
                entrada = Console.ReadLine();
            }

            switch(numero)
            {
                case 1:
                    Console.WriteLine("Ingrese la medida.");
                    entrada = Console.ReadLine();
                    double.TryParse(entrada, out medida);
                    Console.WriteLine("El area de su cuadrado es: " + Calculo_de_area.calcularCuadrado(medida));
                    break;

                case 2:
                    Console.WriteLine("Ingrese la base.");
                    entrada = Console.ReadLine();
                    double.TryParse(entrada, out medida);

                    Console.WriteLine("Ingrese la altura.");
                    entrada = Console.ReadLine();
                    double.TryParse(entrada, out altura);

                    Console.WriteLine("El area de su cuadrado es: " + Calculo_de_area.calcularTriangulo(medida , altura));
                    break;

                case 3:
                    Console.WriteLine("Ingrese el radio.");
                    entrada = Console.ReadLine();
                    double.TryParse(entrada, out medida);

                    Console.WriteLine("El area de su circulo es: " + Calculo_de_area.calcularCirculo(medida));
                    break;
            }

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
