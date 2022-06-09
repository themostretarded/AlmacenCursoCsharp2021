using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Pila<T>
    {
        int tamañoDefault = 100;
        T[] arreglo;
        int indiceActual = 0;
        int numElementos = 0;

        public Pila()
        {
            arreglo = new T[tamañoDefault];
        }
        public Pila( int _tamaño)
        {
            if (_tamaño > 0)
            {
                arreglo = new T[_tamaño];
            }
            else 
            {
                throw new ArgumentOutOfRangeException("atinale pendejo");
            }
        }
        public void Apilar(T elemento) 
        {
            if (numElementos == arreglo.Length)
            {
                throw new Exception("El arreglo esta lleno");
            }
            arreglo[indiceActual] = elemento;
            indiceActual++;
            numElementos++;
        }
        public T Desapilar()
        {
            if (numElementos ==0)
            {
                throw new Exception("El arreglo esta vacio");
            }
            indiceActual--;
            T elemento = arreglo[indiceActual];
            numElementos--;
            return elemento;
        }
    }
}
