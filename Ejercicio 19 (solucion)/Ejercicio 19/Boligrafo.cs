using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19.Clases
{
    class Boligrafo
    {
        private ConsoleColor color;
        private int tinta;

        public Boligrafo()
        {
            this.color = ConsoleColor.White;
            this.tinta = 0;
        }

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public bool pintar(int gasto)
        {
            bool retorno = false;

            if(this.tinta >= gasto)
            {
                this.tinta -= gasto; 
                retorno = true;
            }

            return retorno;
        } 

        public void recargar()
        {
            this.tinta = 100;
        }

        public ConsoleColor getColor()
        {
            return this.color;
        }

        public int getTinta()
        {
            return this.tinta;
        }
    }
}
