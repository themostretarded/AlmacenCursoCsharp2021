using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerablesDemo
{
    class ClientesManager :IEnumerable
    {
        List<Cliente> clientes;
        public ClientesManager()
        {
            clientes = new List<Cliente>() {
                
                new Cliente
                {
                    ID=1,
                    Nombre="Hector"
                },

                new Cliente
                {
                    ID=2,
                    Nombre="Ricardo"
                },

                new Cliente
                {
                    ID=3,
                    Nombre="Liz"
                },

                new Cliente
                {
                    ID=4,
                    Nombre="Cristina"
                },

            };
        }

        public IEnumerator GetEnumerator()
        {
            //return new ClienteEnumerator(clientes);
            foreach (var cliente in clientes)
            {
                yield return cliente;
            }
        }
    }
}
