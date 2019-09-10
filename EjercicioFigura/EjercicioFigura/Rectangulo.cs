using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    public class Rectangulo : Figura
    {

        // Metodo para calcular area 
        public override double CalcularArea()
        {
            
            var ladoA = punto1.CalcularDistancia(new Punto { x=punto1.x,y= punto2.y});
            var ladoB = punto2.CalcularDistancia(new Punto { x = punto1.x, y = punto2.y });

            return (ladoA * ladoB);
        }

        // Metodo para calcular perimetro 
        public override double CalcularPerimetro()
        {
            var ladoA = punto1.CalcularDistancia(new Punto { x = punto1.x, y = punto2.y });
            var ladoB = punto2.CalcularDistancia(new Punto { x = punto1.x, y = punto2.y });

            return ((ladoA *2) + (ladoB *2));
        }
    }
}
