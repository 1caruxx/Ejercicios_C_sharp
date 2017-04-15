using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseFahrenheit;
using ClaseCelsius;

namespace ClaseKelvin
{
    public class Kelvin
    {
        public double cantidad;

        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static Kelvin operator +(Kelvin grado, double numero)
        {
            Kelvin gradoAuxiliar = new Kelvin(grado.cantidad + numero);
            return gradoAuxiliar;
        }

        public static Kelvin operator +(Kelvin grado, Kelvin grado2)
        {
            Kelvin gradoAuxiliar = new Kelvin(grado.cantidad + grado2.cantidad);
            return gradoAuxiliar;
        }

        public static Kelvin operator +(Kelvin grado , Fahrenheit grado2)
        {
            Kelvin gradoAuxiliar = new Kelvin(grado.cantidad + ((grado2.cantidad + 459.67) * 5 / 9));
            return gradoAuxiliar;
        }

        public static Kelvin operator -(Kelvin grado, double numero)
        {
            Kelvin gradoAuxiliar = new Kelvin(grado.cantidad - numero);
            return gradoAuxiliar;
        }

        public static Kelvin operator -(Kelvin grado, Kelvin grado2)
        {
            Kelvin gradoAuxiliar = new Kelvin(grado.cantidad - grado2.cantidad);
            return gradoAuxiliar;
        }

        public static Kelvin operator -(Kelvin grado, Fahrenheit grado2)
        {
            Kelvin gradoAuxiliar = new Kelvin(grado.cantidad - ((grado2.cantidad + 459.67) * 5 / 9));
            return gradoAuxiliar;
        }

        public static implicit operator Kelvin(Fahrenheit grado)
        {
            return new Kelvin((grado.cantidad + 459.67) * 5 / 9);
        }
    }
}
