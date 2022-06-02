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
            Triangulo t = new Triangulo
            {
                Lado1 = 20

            };
            Triangulo t2 = new Triangulo
            {
                Lado3 = 50

            };
            Triangulo t3 = new Triangulo
            {
                Lado1 = 15,
                Lado3 = 50

            };
            Triangulo t4 = new Triangulo
            {
                Lado1 = 50,
                Lado2 = 10,
                Lado3 = 5

            };
            Triangulo t5 = new Triangulo("Rojo")
            {
                Lado2 = 5,
                Lado3 = 1

            };
            //Printer p = new Printer(10,15);
            //p.Z = 10;
            //int x = p.Z;
            //p.Print();
            //p.X = 20;
            //p.Y = 15;
            //int x = p.X;
            //int y = p.Y;
            //p.Print();

            //p.X += 10;

            //int x = p.ObtenerX();
            //p.AsignarX(x + 10);
            //int y = p.ObtenerY();
            //p.AsignarY(25);
            Console.ReadLine();
        }
       
    }
}
