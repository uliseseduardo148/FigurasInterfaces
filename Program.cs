using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opción \n1.Triángulo\n2.Rectángulo\n3.Círculo");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Triangulo triangulo = new Triangulo();
                    triangulo.PedirDatosTriangulo();
                    triangulo.CalcularArea();
                    triangulo.VisualizarResultadoTriangulo();
                    triangulo.CalcularPerimetro();
                    break;
                case 2:
                    Rectangulo rectangulo = new Rectangulo();
                    rectangulo.PedirDatosRectangulo();
                    rectangulo.CalcularArea();
                    rectangulo.VisualizarResultadoRectangulo();
                    rectangulo.CalcularPerimetro();
                    break;
                case 3:
                    Circulo circulo = new Circulo();
                    circulo.PedirDatosCirculo();
                    circulo.CalcularArea();
                    circulo.VisualizarResultadoCirculo();
                    circulo.CalcularPerimetro();
                    break;
                default:
                    Console.WriteLine("No existe la opción");
                    break;

            }
            Console.ReadKey();
        }
    }
}
