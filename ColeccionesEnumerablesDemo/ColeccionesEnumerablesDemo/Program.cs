using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientesManager manager = new ClientesManager();

            //foreach (Cliente cliente in manager)
            //{
            //    Console.WriteLine(cliente.Nombre);
            //}var
            var enumerator = manager.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(((Cliente)enumerator.Current).Nombre);
            }

            Console.ReadLine();

        }
    }
}
