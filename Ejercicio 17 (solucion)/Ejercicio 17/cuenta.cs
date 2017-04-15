using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class cuenta
    {
        private string nombre;
        private long numeroDeCuenta;
        private double saldo;
        private eTipoInteres tipoDeInteres;

        public cuenta()
        {
            this.nombre = "Sin nombre";
            this.numeroDeCuenta = 0;
            this.saldo = 0;
            this.tipoDeInteres =  (eTipoInteres) 0;
        }

        public void getNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void getNumeroDeCuenta(string numeroDeCuenta)
        {
            while(!long.TryParse(numeroDeCuenta , out this.numeroDeCuenta))
            {
                Console.WriteLine("Error, reingrese.");
                numeroDeCuenta = Console.ReadLine();
            }
        }

        public void getSaldo(string saldo)
        {
            while (!double.TryParse(saldo, out this.saldo))
            {
               Console.WriteLine("Error, reingrese.");
               saldo = Console.ReadLine();
            }
        }

        public void getTipoDeInteres(string entrada)
        {
            int numero;

            while (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Error, reingrese.");
                entrada = Console.ReadLine();
            }
            this.tipoDeInteres = (eTipoInteres)numero;
        }
    }
}
