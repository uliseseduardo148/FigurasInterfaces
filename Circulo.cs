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
   * M�todo encargado de pedir el radio y asignarlo al atributo de la clase
   */
    public void PedirDatosCirculo() {
        Console.WriteLine("Radio del circulo");
        RadioCirculo = Convert.ToDouble(Console.ReadLine());
    }

    /*
    * M�todo encargado de mostrar el resultado del �rea al usuario
    */
    public void VisualizarResultadoCirculo() {
        Console.WriteLine("El �rea del c�rculo es "+AreaCirculo);
    }

    /*
     * M�todo que calcula el �rea, lo hereda de la interfaz Figura
     */
    public void CalcularArea()
    {
        AreaCirculo = Convert.ToDouble(Math.PI * Math.Pow(RadioCirculo, 2));
    }

    /*
    * M�todo que calcula el per�metro de la figura y muestra el resultado al usuario, lo hereda de la interfaz Figura
    */
    public void CalcularPerimetro()
    {
        double perimetro = Convert.ToDouble(2 * Math.PI * RadioCirculo);
        Console.WriteLine("Per�metro " + perimetro);
    }
}