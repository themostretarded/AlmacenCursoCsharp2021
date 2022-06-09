using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{

    class Dato<T> :IAlmacenador<T>, IObtenedor<T>
    {
        T dato;

        T IObtenedor<T>.GetDato()
        {
            return dato;
        }

        void IAlmacenador<T>.SetDato(T _dato)
        {
            dato = _dato;
        }
        //T IDato<T>.GetDato()
        //{
        //    return dato;
        //}

        //void IDato<T>.SetDato(T _dato)
        //{
        //    dato = _dato;
        //}
    }

    interface IDato<T>
    {
        void SetDato(T _dato);
        T GetDato();
    }
    interface IAlmacenador<T>
    {
        void SetDato(T _dato);
    }
    interface IObtenedor<out T>
    {
        T GetDato();
    }
}
