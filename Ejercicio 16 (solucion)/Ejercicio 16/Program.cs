using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. #16";

            string entrada;
            string entrada2;
            int nota;
            int nota2;

            alumno alumno;

            alumno = new alumno();

            Console.WriteLine("Ingrese nombre para el alumno:");
            alumno.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido para el alumno:");
            alumno.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese legajo para el alumno:");
            int.TryParse(Console.ReadLine() , out alumno.legajo);

            Console.WriteLine("Ingrese la nota del primer parcial del alumno:");
            entrada = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del segundo parcial del alumno:");
            entrada2 = Console.ReadLine();

            int.TryParse(entrada , out nota);
            int.TryParse(entrada2, out nota2);

            alumno.estudiar(nota, nota2);

            alumno.calcularFinal();
            alumno.mostrar();

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
