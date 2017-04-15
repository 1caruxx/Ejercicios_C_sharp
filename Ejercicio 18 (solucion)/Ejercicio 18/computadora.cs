using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    class computadora
    {
        private bool estaEncendida;
        private eMarca marca;
        private float peso;
        private eProcesador procesador;

        public computadora()
        {
            this.estaEncendida = false;
            this.marca = (eMarca)0;
            this.peso = 0;
            this.procesador = (eProcesador)0;
        }


    }
}
