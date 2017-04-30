using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Cliente
    {
        public string nombre;
        public int telefono;
        public string direccion;
        public string ciudad;
        public string provincia;
        public int codigoPostal;
        public int cuit;
        public double iva;

        public Cliente()
        {
            this.nombre = "";
            this.direccion = "";
            this.ciudad = "";
            this.provincia = "";
        }
    }
}
