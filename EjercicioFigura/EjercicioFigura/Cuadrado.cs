using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    public class Cuadrado : Figura
    {       
        // Metodo para calcular area 
        public override double CalcularArea()
        {
            var _longitud = punto1.CalcularDistancia(punto2);
            return _longitud * _longitud;
        }

        // Metodo para calcular perimetro 
        public override double CalcularPerimetro()
        {
            var _longitud = punto1.CalcularDistancia(punto2);
            return _longitud*4;
        }
    }
}
