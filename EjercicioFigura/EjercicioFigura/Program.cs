using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            // Ppp.ress Ctrl+F5 (or go to Debug > Start Without Debugging) to run your a
            Console.WriteLine("Ejercicio Figura!");

            Figura[] figura = {
                new Cuadrado() {punto1 =new Punto() { x=1 , y=1 },punto2 = new Punto() { x = 5, y = 1 } , figura = "Cuadrado" },
                new Circulo() {punto1 =new Punto() { x=1 , y=1 },punto2 = new Punto() { x = 5, y = 1 } ,figura = "Circulo"},
                new Rectangulo() {punto1 =new Punto() { x=1 , y=1 },punto2 = new Punto() { x = 5, y = 10 } ,figura = "Rectangulo"}
            };

            foreach (var item in figura)
            {
                Console.WriteLine(string.Format("El area del {1} {0}", item.CalcularArea(), item.figura));
                Console.WriteLine(string.Format("El Perimetro del {1} {0}", item.CalcularPerimetro(), item.figura));

            }



            Console.ReadKey();

            //Figura figura = new Circulo(5);


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
