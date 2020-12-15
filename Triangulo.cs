using FigurasInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Triangulo : IFigura {

    public Triangulo() {
    }

    public double BaseTriangulo;
    public double AlturaTriangulo;
    public double AreaTriangulo;

    /*
     * M�todo encargado de pedir valores al usuario y asignarlos a los atributos de la clase
     */
    public void PedirDatosTriangulo() {
        Console.WriteLine("Base");
        BaseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Altura");
        AlturaTriangulo = Convert.ToDouble(Console.ReadLine());
    }

    /*
     * M�todo encargado de mostrar el resultado del �rea al usuario
     */
    public void VisualizarResultadoTriangulo() {
        Console.WriteLine("El �rea es " + AreaTriangulo);
    }

    /*
     * M�todo que calcula el �rea del tri�ngulo, lo hereda de la interfaz Figura
     */
    public void CalcularArea()
    {
        AreaTriangulo = (BaseTriangulo * AlturaTriangulo) / 2;
    }

    /*
     * M�todo que calcula el per�metro de la figura y muestra el resultado al usuario, lo hereda de la interfaz Figura
     */
    public void CalcularPerimetro()
    {
        double perimetro = BaseTriangulo + AlturaTriangulo + Math.Sqrt(Math.Pow(BaseTriangulo, 2) + Math.Pow(AlturaTriangulo, 2));
        Console.WriteLine("El per�metro  es " + perimetro);
    }
}