using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Circulo c = new Circulo();
            //IFigura f1 = c;
            //f1.Dibujar();
            //IRenderizador r = c;
            //r.Dibujar();

            //Linea l = new Linea();

            //IFigura f = c;
            //f = l;
            //f.Dibujar();

            //f.Dibujar();
            
            //l.Dibujar();

            FiguraBase fbase = new FiguraBase();
            fbase.ObtenerUbicacion();
        }

        static void CalcularArea(IFigura figura)
        {
            if (figura is Circulo)
            {
                figura.Dibujar();
            }
            else {
                figura.Dibujar();
            }
        }

    }
}
