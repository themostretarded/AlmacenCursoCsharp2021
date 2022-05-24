using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class Linea : IFigura
    {
        double puntoXInicial;
        double puntoYInicial;
        double puntoXFinal;
        double puntoYFinal;

        public double CalcularArea { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Dibujar()
        {
            throw new NotImplementedException();
        }
    }
}
