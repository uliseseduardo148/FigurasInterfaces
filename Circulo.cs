using FigurasInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Circulo : IFigura  {

    public Circulo() {
    }

    public double RadioCirculo;
    public double AreaCirculo;

    /*
   * Método encargado de pedir el radio y asignarlo al atributo de la clase
   */
    public void PedirDatosCirculo() {
        Console.WriteLine("Radio del circulo");
        RadioCirculo = Convert.ToDouble(Console.ReadLine());
    }

    /*
    * Método encargado de mostrar el resultado del área al usuario
    */
    public void VisualizarResultadoCirculo() {
        Console.WriteLine("El área del círculo es "+AreaCirculo);
    }

    /*
     * Método que calcula el área, lo hereda de la interfaz Figura
     */
    public void CalcularArea()
    {
        AreaCirculo = Convert.ToDouble(Math.PI * Math.Pow(RadioCirculo, 2));
    }

    /*
    * Método que calcula el perímetro de la figura y muestra el resultado al usuario, lo hereda de la interfaz Figura
    */
    public void CalcularPerimetro()
    {
        double perimetro = Convert.ToDouble(2 * Math.PI * RadioCirculo);
        Console.WriteLine("Perímetro " + perimetro);
    }
}