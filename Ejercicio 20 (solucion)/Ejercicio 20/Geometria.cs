using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }
    }

    public class Rectangulo
    {
        public double area; 
        public double lado; 
        public double perimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;

        public Rectangulo(Punto vertice1 , Punto vertice3)
        {
            int baseDelRectangulo;

            baseDelRectangulo = Math.Abs(vertice1.getX);
        }

    }
}
