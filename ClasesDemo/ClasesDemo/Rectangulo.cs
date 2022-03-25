using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDemo
{
    internal class Rectangulo
    {
        double baseRectangulo;
        double alturaRectangulo;
        string color;

        public Rectangulo() {
            baseRectangulo = 0;
            alturaRectangulo = 0;
            color = "negro";
        }

        public Rectangulo( double baseRectanguloInicial,double alturaRectanguloInicial) {
            baseRectangulo = baseRectanguloInicial;
            alturaRectangulo = alturaRectanguloInicial;
            
        }

        public double CalcularArea() {
            return alturaRectangulo * baseRectangulo;
        }

        public double CalcularPerimetro() {
            return (2 * alturaRectangulo) + (2 * baseRectangulo);
        }
        //definiendo metodo estatico para solo recibir y manda informacion y nada mas
        public static double CalcularPerimetroRectangulo(double alturaRectangulo,double baseRectangulo) {
            return (2 * alturaRectangulo) + (2 * baseRectangulo);
        }

        public void Deconstruct(out double baseRect,out double alturaRect) {
            baseRect=baseRectangulo;
            alturaRect = alturaRectangulo;
        }
    }
}
