using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class alumno
    {
        public string nombre;
        public string apellido;
        public int legajo;
        public static Random numeroRandom;
        private int nota1;
        private int nota2;
        private int notaFinal;

        public static void Random()
        {
            numeroRandom = new Random();
        }

        public alumno ()
        {
            this.nombre = "Sin nombre";
            this.apellido = "Sin apellido";
            this.legajo = 0;
        }

        public void estudiar (int nota1 , int nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void calcularFinal()
        {
            if(this.nota1>=4 && this.nota2>=4)
            {
                this.notaFinal = numeroRandom.Next(1 , 11);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void mostrar()
        {
            if(notaFinal == -1)
            {
                Console.WriteLine("Apellido y nombre: " + this.apellido + ", " + this.nombre);
                Console.WriteLine("Legajo: " + this.legajo);
                Console.WriteLine("Nota del primer parcial: " + nota1);
                Console.WriteLine("Nota del segundo parcial: " + nota2);
            }
            else
            {
                Console.WriteLine("Apellido y nombre: " + this.apellido + ", " + this.nombre);
                Console.WriteLine("Legajo: " + this.legajo);
                Console.WriteLine("Nota del primer parcial: " + nota1);
                Console.WriteLine("Nota del segundo parcial: " + nota2);
                Console.WriteLine("Nota del final: " + notaFinal);
            }
        }
    }
}
