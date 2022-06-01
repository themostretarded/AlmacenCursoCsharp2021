using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer(10,15);
            p.Print();

            int x = p.ObtenerX();
            p.AsignarX(x + 10);
            //int y = p.ObtenerY();
            p.AsignarY(25);

            Console.ReadLine();
        }
       
    }
}
