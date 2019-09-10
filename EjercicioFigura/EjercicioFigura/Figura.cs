using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    public abstract class Figura
    {
        // Primer punto
        public Punto punto1 { get; set; }

        // Segundo punto
        public Punto punto2 { get; set; }

        // Identificador figura
        public string figura { get; set; }

        // Metodo para calcular area 
        public abstract double CalcularArea();

        // Metodo para calcular perimetro 
        public abstract double CalcularPerimetro();
    }
}
