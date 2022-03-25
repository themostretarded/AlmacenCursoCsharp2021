using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDemo
{
    internal class Circulo
    {
        int radio;
        public const double PI = 3.14;
        public static int numeroDeCirculos;
        public Circulo(int radioInicial) {
            radio = radioInicial;
            numeroDeCirculos++;
        }
        public double CalcularArea() { 
            return Math.PI * radio * radio;
        }



    }
}
