using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    public class Circulo : Figura
    {
        // Metodo para calcular area 
        public override double CalcularArea()
        {
            var _radio = punto1.CalcularDistancia(punto2);
            return (_radio * _radio * 3.14);
        }

        // Metodo para calcular perimetro 
        public override double CalcularPerimetro()
        {
            var _radio = punto1.CalcularDistancia(punto2);
            return 2 * 3.14 * _radio;
        }

    }
}
