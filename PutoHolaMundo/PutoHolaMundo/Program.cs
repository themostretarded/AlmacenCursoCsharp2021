using System;

namespace PutoHolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter = 'I';
            Console.WriteLine(caracter);

            String nombre = "Iaefe8()$";
            Console.WriteLine(nombre);

            //limite int
            int entero = 2147483647;
            Console.WriteLine(entero);


            long entero2 = 9223372036854775807;
            Console.WriteLine(entero2);

            float numeroFloat1 = 3.1416f;
            Console.WriteLine(numeroFloat1);

            float numeroFloat2 = 3.1416375894053829f;
            Console.WriteLine(numeroFloat2);

            double numeroDouble1 = 3.1416;
            Console.WriteLine(numeroDouble1);

            double numeroDouble2 = 3.1416375894053829;
            Console.WriteLine(numeroDouble2);

            decimal numerodecimal1 = 3.1416m;
            Console.WriteLine(numerodecimal1);

            decimal numeroDecimal2 = 3.1416375894053829m;
            Console.WriteLine(numeroDouble2);

            Console.ReadLine();
        }
    }
}
