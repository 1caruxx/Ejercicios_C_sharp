using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseCelsius;
using ClaseKelvin;

namespace ClaseFahrenheit
{
    public class Fahrenheit
    {
        public double cantidad;

        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static Fahrenheit operator +(Fahrenheit grado, double numero)
        {
            return new Fahrenheit(grado.cantidad + numero);
        }

        public static Fahrenheit operator +(Fahrenheit grado, Fahrenheit grado2)
        {
            Fahrenheit gradoAuxiliar = new Fahrenheit(grado.cantidad + grado2.cantidad);
            return gradoAuxiliar;
        }

        public static Fahrenheit operator +(Fahrenheit grado, Celsius grado2)
        {
            Fahrenheit gradoAuxiliar = new Fahrenheit(grado.cantidad + (grado2.cantidad * (9 / 5) + 32));
            return gradoAuxiliar;
        }

        public static Fahrenheit operator +(Fahrenheit grado, Kelvin grado2)
        {
            Fahrenheit gradoAuxiliar = new Fahrenheit(grado.cantidad + (grado2.cantidad * 9 / 5 - 459.67));
            return gradoAuxiliar;
        }

        public static Fahrenheit operator -(Fahrenheit grado, double numero)
        {
            return new Fahrenheit(grado.cantidad - numero);
        }

        public static Fahrenheit operator -(Fahrenheit grado, Fahrenheit grado2)
        {
            Fahrenheit gradoAuxiliar = new Fahrenheit(grado.cantidad - grado2.cantidad);
            return gradoAuxiliar;
        }

        public static Fahrenheit operator -(Fahrenheit grado, Celsius grado2)
        {
            Fahrenheit gradoAuxiliar = new Fahrenheit(grado.cantidad - (grado2.cantidad * (9 / 5) + 32));
            return gradoAuxiliar;
        }

        public static Fahrenheit operator -(Fahrenheit grado, Kelvin grado2)
        {
            Fahrenheit gradoAuxiliar = new Fahrenheit(grado.cantidad - (grado2.cantidad * 9 / 5 - 459.67));
            return gradoAuxiliar;
        }

        public static implicit operator Fahrenheit(double numero)
        {
            return new Fahrenheit(numero);
        }

        public static implicit operator Fahrenheit(Celsius grado)
        {
            return new Fahrenheit(grado.cantidad * (9 / 5) + 32);
        }

        public static implicit operator Fahrenheit(Kelvin grado)
        {
            return new Fahrenheit(grado.cantidad * 9 / 5 - 459.67);
        }
    }
}
