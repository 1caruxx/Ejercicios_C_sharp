using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Cuenta
    {
        private string _nombre;
        private Int64 _nroCuenta;
        private double _saldo;
        private Single _tipoInteres;

        public Cuenta()
        {
            _nombre = "";
        }

        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public Int64 nroCuenta
        {
            get { return this._nroCuenta; }
            set { this._nroCuenta = value; }
        }

        public double saldo
        {
            get { return this._saldo; }
        }

        public Single tipoInteres
        {
            get { return this._tipoInteres; }
            set { this._tipoInteres = value; }
        }

        public void depositar(Int64 deposito)
        {
            this._saldo = deposito;
        }

        public static void mostrar(Cuenta cuenta)
        {
            Console.WriteLine(cuenta.nombre);
            Console.WriteLine(cuenta.nroCuenta);
            Console.WriteLine(cuenta.saldo);
            Console.WriteLine(cuenta.tipoInteres);
        }
    }
}
