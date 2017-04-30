using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBoligrafo
{
    public class Boligrafo
    {
        private string _marca;
        private string _color;
        private int _cantidadTinta;

        public Boligrafo(string marca)
        {
            this._marca = marca;
            this._cantidadTinta = 0;
            this._color = "Sin color";
        }

        public Boligrafo(string color , int cantidad)
        {
            this._marca = "Sin marca";
            this._color = color;
            this._cantidadTinta = cantidad;
        }

        public Boligrafo(string marca , string color) : this(marca)
        {
            this._color = color;
            this._cantidadTinta = 0;
        }

        public Boligrafo(string marca, string color , int cantidad) : this(marca , color)
        {
            this._cantidadTinta = cantidad;
        }

        private void Mostrar()
        {
            Console.WriteLine(this._marca);
            Console.WriteLine(this._color);
            Console.WriteLine(this._cantidadTinta);
        }

        public static void MostrarBoligrafos(List<Boligrafo> listaDeBoligrafos)
        {
            foreach (Boligrafo boligrafoRecorrido in listaDeBoligrafos)
            {
                boligrafoRecorrido.Mostrar();
            }
        }

        public void Escribir (int tintaAConsumir)
        {
            if(this._cantidadTinta >= tintaAConsumir)
            {
                this._cantidadTinta -= tintaAConsumir;
            }
            else
            {
                this.Mostrar();
            }
        }

        public bool RecargarTinta()
        {
            bool retorno = false;

            if (this._cantidadTinta < 50)
            {
                this._cantidadTinta = 100;
                retorno = true;
            }

            return retorno;
        }

        public bool RecargarTinta(int tintaARecargar)
        {
            bool retorno = false;

            if (this._cantidadTinta > 50)
            {
                this._cantidadTinta = tintaARecargar;
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Boligrafo boligrafo , Boligrafo boligrafo2)
        {
            bool retorno = false;

            return retorno;
        }
    }
}
