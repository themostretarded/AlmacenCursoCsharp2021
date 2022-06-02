using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDemo
{
    class Triangulo
    {
        int lado1;
        int lado2;
        int lado3;
        string color;
        
        public int Lado1 
        {
            get => lado1;
            set => lado1 = value;
        }
        public int Lado2
        {
            get => lado2;
            set => lado2 = value;
        }
        public int Lado3
        {
            get => lado3;
            set => lado3 = value;
        }
        public Triangulo() { }
        public Triangulo(string _color)
        {
            color = _color;
        }
    }
}
