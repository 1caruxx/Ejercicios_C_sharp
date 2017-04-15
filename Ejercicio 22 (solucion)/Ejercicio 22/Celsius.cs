using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseFahrenheit;

namespace ClaseCelsius
{
    public class Celsius
    {
        public double cantidad;

        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static Celsius operator +(Celsius grado, double numero)
        {
            return new Celsius(grado.cantidad + numero);
        }

        public static Celsius operator +(Celsius grado, Celsius grado2)
        {
            return new Celsius(grado.cantidad + grado2.cantidad);
        }

        public static Celsius operator +(Celsius grado , Fahrenheit grado2)
        {
            return new Celsius(grado.cantidad + ((grado2.cantidad-32) * 5/9));
        }

        public static Celsius operator -(Celsius grado, double numero)
        {
            return new Celsius(grado.cantidad - numero);
        }

        public static Celsius operator -(Celsius grado, Celsius grado2)
        {
            return new Celsius(grado.cantidad - grado2.cantidad);
        }

        public static Celsius operator -(Celsius grado, Fahrenheit grado2)
        {
            return new Celsius(grado.cantidad - ((grado2.cantidad - 32) * 5 / 9));
        }

        public static implicit operator Celsius(double numero)
        {
            return new Celsius(numero);
        }

        public static implicit operator Celsius(Fahrenheit grado)
        {
            return new Celsius((grado.cantidad - 32) * 5 / 9);
        }

    }
}
