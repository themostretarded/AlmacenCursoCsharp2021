using System;
using static System.Console;
using static ClasesDemo.Circulo;

namespace ClasesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangulo rectangulo = new Rectangulo(23, 50);
            //double ResultadoArea = rectangulo.CalcularArea();
            //double ResultadoPerimetro = rectangulo.CalcularPerimetro();

            // double resultadoPerimetro2 = 
            //     Rectangulo.CalcularPerimetroRectangulo(23, 24);

            // //definir tupla para la decontrusccion
            // (var baseRect, var alturaRect) = rectangulo;

            // Console.WriteLine(baseRect);
            // Console.WriteLine(alturaRect);

            Circulo circulo1 = new Circulo(20);
            Circulo circulo2 = new Circulo(50);
            Circulo circulo3 = new Circulo(10);

            //SIN la necesidad del console porque es traida arriba por ser una clase static
            WriteLine(numeroDeCirculos);

            //definir una clase anonima
            var objetoAnonimo = new { area = 3, campo2 = 5 };


            ReadLine();

        }
    }
}
