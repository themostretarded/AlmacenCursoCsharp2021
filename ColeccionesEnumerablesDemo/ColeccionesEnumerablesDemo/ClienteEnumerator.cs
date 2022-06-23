using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerablesDemo
{
    class ClienteEnumerator : IEnumerator
    {
        int posicion = -1;
        List<Cliente> clientes = null;
        public ClienteEnumerator(List<Cliente> _clientes)
        {
            clientes = _clientes;
        }
        public object Current {
            get
            {
                try
                {
                    return clientes[posicion];
                } catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            posicion++;
            return posicion < clientes.Count;
        }

        public void Reset()
        {
            posicion = -1;
        }
    }
}
