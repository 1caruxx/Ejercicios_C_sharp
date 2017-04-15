using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21.Dolar
{
    public class Dolar
    {
        private double cantidad;

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double getDolar()
        {
            return this.cantidad;
        }

        public static Dolar operator +(Dolar dolar, double numero)
        {
            dolar.cantidad += numero;
            return dolar;
        }

        public static Dolar operator +(Dolar dolar1, Dolar dolar2)
        {
            Dolar dolarAuxiliar = new Dolar(dolar1.cantidad + dolar2.cantidad);
            return dolarAuxiliar;
        }

        public static Dolar operator +(Euro.Euro euro, Dolar dolar)
        {
            Dolar dolarAuxiliar = new Dolar(euro.getEuro() + dolar.cantidad);
            dolarAuxiliar.cantidad += 0.3642 * euro.getEuro();
            return dolarAuxiliar;
        }

        public static Dolar operator -(Dolar dolar1, Dolar dolar2)
        {
            Dolar dolarAuxiliar = new Dolar(dolar1.cantidad - dolar2.cantidad);
            return dolarAuxiliar;
        }

        public static Dolar operator -(Euro.Euro euro, Dolar dolar)
        {
            Dolar dolarAuxiliar = new Dolar(euro.getEuro() - dolar.cantidad);
            dolarAuxiliar.cantidad -= 0.3642 * euro.getEuro();
            return dolarAuxiliar;
        }

        public static implicit operator Dolar(double numero)
        {
            return new Dolar(numero);
        }

        public static implicit operator Dolar(Euro.Euro euro)
        {
            return new Dolar(euro.getEuro() * 1.3642);
        }
    }
}
