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
    * M�todo encargado de pedir valores al usuario y asignarlos a los atributos de la clase
    */
    public void PedirDatosRectangulo() {
        Console.WriteLine("Base");
        BaseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Altura");
        AlturaRectangulo = Convert.ToDouble(Console.ReadLine());
    }

    /*
     * M�todo encargado de mostrar el resultado del �rea al usuario
     */
    public void VisualizarResultadoRectangulo() {
        Console.WriteLine("El �rea del rect�ngulo es " + AreaRectangulo);
    }

    /*
     * M�todo que calcula el �rea del rect�ngulo, lo hereda de la interfaz Figura
     */
    public void CalcularArea()
    {
        AreaRectangulo = BaseRectangulo * AlturaRectangulo;
    }

    /*
    * M�todo que calcula el per�metro de la figura y muestra el resultado al usuario, lo hereda de la interfaz Figura
    */
    public void CalcularPerimetro()
    {
        double perimetro = BaseRectangulo * 2 + AlturaRectangulo * 2;
        Console.WriteLine("Per�metro " + perimetro);
    }
}