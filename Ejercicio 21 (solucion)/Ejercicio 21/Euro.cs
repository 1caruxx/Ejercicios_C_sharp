using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_21.Euro
{
   

    public class Euro
    {
        private double cantidad;

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double getEuro()
        {
            return this.cantidad;
        }

        public static Euro operator +(Euro euro, double numero)
        {
            euro.cantidad += numero;
            return euro;
        }

        public static Euro operator +(Euro euro1 , Euro euro2)
        {
            Euro euroAuxiliar = new Euro(euro1.cantidad + euro2.cantidad);
            return euroAuxiliar;
        }

        public static Euro operator +(Euro euro , Dolar.Dolar dolar)
        {
            Euro euroAuxiliar = new Euro(euro.cantidad + dolar.getDolar());
            euroAuxiliar.cantidad -= 0.3642 * dolar.getDolar();
            return euroAuxiliar;
        }

        public static Euro operator -(Euro euro1, Euro euro2)
        {
            Euro euroAuxiliar = new Euro(euro1.cantidad - euro2.cantidad);
            return euroAuxiliar;
        }

        public static Euro operator -(Euro euro, Dolar.Dolar dolar)
        {
            Euro euroAuxiliar = new Euro(euro.cantidad - dolar.getDolar());
            euroAuxiliar.cantidad += 0.3642 * dolar.getDolar();
            return euroAuxiliar;
        }

        public static implicit operator Euro(double numero)
        {
            return new Euro(numero);
        }

        public static implicit operator Euro(Dolar.Dolar dolar)
        {
            return new Euro(dolar.getDolar() * 0.6358);
        }
    }
}
