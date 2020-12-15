using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Interfaz que hereda sus métodos a las clases
 */
namespace FigurasInterfaces
{
    interface IFigura
    {
        /*
        * Método declarado para el cálculo de área
        */
        void CalcularArea();

        /*
        * Método declarado para el cálculo de perímetro
        */
        void CalcularPerimetro();
    }
}
