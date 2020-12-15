using FigurasInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rectangulo : IFigura {

    public Rectangulo() {
    }

    public double BaseRectangulo;
    public double AlturaRectangulo;
    public double AreaRectangulo;

    /*
    * Método encargado de pedir valores al usuario y asignarlos a los atributos de la clase
    */
    public void PedirDatosRectangulo() {
        Console.WriteLine("Base");
        BaseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Altura");
        AlturaRectangulo = Convert.ToDouble(Console.ReadLine());
    }

    /*
     * Método encargado de mostrar el resultado del área al usuario
     */
    public void VisualizarResultadoRectangulo() {
        Console.WriteLine("El área del rectángulo es " + AreaRectangulo);
    }

    /*
     * Método que calcula el área del rectángulo, lo hereda de la interfaz Figura
     */
    public void CalcularArea()
    {
        AreaRectangulo = BaseRectangulo * AlturaRectangulo;
    }

    /*
    * Método que calcula el perímetro de la figura y muestra el resultado al usuario, lo hereda de la interfaz Figura
    */
    public void CalcularPerimetro()
    {
        double perimetro = BaseRectangulo * 2 + AlturaRectangulo * 2;
        Console.WriteLine("Perímetro " + perimetro);
    }
}