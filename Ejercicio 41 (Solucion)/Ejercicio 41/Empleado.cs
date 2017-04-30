using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    public class Empleado:SerHumano
    {
        private float _sueldo;

        public Empleado(string nombre , Single peso , Single altura , string sexo , float sueldo):base(nombre, peso , altura , sexo)
        {
            this._sueldo = sueldo;
        }

        public string trabajar()
        {
            return "Este hombre esta trabajando, se ve que no es ningun perezoso (A diferencia del programador que esta escribiendo este codigo :P)";
        }
     
    }
}
