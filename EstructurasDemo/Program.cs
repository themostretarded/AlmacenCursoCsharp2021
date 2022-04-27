using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point? p = new Point();
            //Print(p);
            StructPoint s1 = new StructPoint();
            StructPoint s2 = s1;
            Console.WriteLine(s1.X);
            Console.WriteLine(s2.X);
            s1.X++;
            Console.WriteLine(s1.X);
            Console.WriteLine(s2.X);
            Console.ReadLine();
        }
        //static void Print(Point? p) {
        //    Console.WriteLine(p.Value.X);
        //}
    }
}
