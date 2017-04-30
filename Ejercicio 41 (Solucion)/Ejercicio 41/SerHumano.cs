using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    public class SerHumano
    {
        private string _nombre;
        private Single _peso;
        private Single _altura;
        private string _sexo;

        public SerHumano()
        {
            this._nombre = "Sin asignar";
            this._sexo = "Sin asignar";
        }

        public SerHumano(string nombre , Single peso , Single altura , string sexo)
        {
            this._nombre = nombre;
            this._peso = peso;
            this._altura = altura;
            this._sexo = sexo;
        }

        public string comer()
        {
            return "Esta persona esta llenita guey";
        }

        public bool dormir()
        {
            return true;
        }
    }
}
