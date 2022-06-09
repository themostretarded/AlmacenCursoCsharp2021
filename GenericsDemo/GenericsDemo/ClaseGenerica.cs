using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    interface IInterface<T>
    {
        T dato { get; set; }
    }
    public interface IHacerAlgo
    {
        string HacerAlgo();
    }
    struct EstructuraGenerica<T>
    {
        T dato;
    }
    class ClaseGenerica<T,U> where T : IHacerAlgo
    {
        T dato;
        U dato2;

        public ClaseGenerica(T _dato)
        {
            dato = _dato;
        }
        public void HacerAlgo(T parametro)
        {
            Console.WriteLine(parametro.HacerAlgo());

        }
    }
}
