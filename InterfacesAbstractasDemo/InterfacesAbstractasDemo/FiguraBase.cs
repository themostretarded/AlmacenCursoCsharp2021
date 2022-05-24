using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{

    class FiguraDerivadaAgain : FiguraDerivada {
        public override void ObtenerTop()
        {
            base.ObtenerTop();
        }
        public override void ObtenerUbicacion()
        {
            base.ObtenerUbicacion();
        }
    }
    class FiguraDerivada : FiguraBase
    {
        public sealed override void ObtenerUbicacion()
        {
            base.ObtenerUbicacion();
        }
        public sealed override void ObtenerTop()
        {
            throw new NotImplementedException();
        }
    }
    abstract class FiguraBase
    {
        protected string colorFigura;
        public virtual void ObtenerUbicacion() {
            Console.WriteLine("x,y");
        }
        public abstract void ObtenerTop();
    }
}
