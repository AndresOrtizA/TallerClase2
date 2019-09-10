using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    public class Punto
    {
        public int x { get; set; }
        public int y { get; set; }

        //Distancia entre puntos
        public double CalcularDistancia(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow(this.x - pPunto.x, 2) + Math.Pow(this.y - pPunto.y, 2));
        }

    }
}
