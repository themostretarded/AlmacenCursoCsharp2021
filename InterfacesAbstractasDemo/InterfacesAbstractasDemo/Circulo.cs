using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{

    

    sealed class Circulo:FiguraBase,IFigura, IRenderizador
    {
        int radio;

        public double CalcularArea { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        void IFigura.Dibujar()
        {
            throw new NotImplementedException();
        }
        void IRenderizador.Dibujar() { }

        public void Renderizar()
        {
            throw new NotImplementedException();
        }

        public override void ObtenerTop()
        {
            throw new NotImplementedException();
        }
    }
}
