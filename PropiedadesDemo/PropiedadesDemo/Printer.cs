using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDemo
{
    class Printer
    {
        //int z;
        //public int Z
        //{
        //    get { return z; }
        //    set { z = value; }
        //}
        //public int Z { get; } = 10;
        public int Prueba {
            get
            {
                return 1;
            }
            set
            {
                int temp = value;
            }
            //Borrando el set se vuelve solo lectura y si borras get se vuelve solo escritura
        }
        public int X
        {
            get=> x;
            set=> x = VerificarX(value);
        }
        public int Y {
            get { return y; }
            set { y = VerificarY(value); }  
        }
        int x;
        int y;
        public Printer(int _x, int _y)
        {
            x = VerificarX(_x);
            y = VerificarY(_y);
            //Z = 10;
        }
        
        public void Print()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("x");
        }
        private int VerificarX(int _x)
        {
            if (_x < 0 || _x > 60)
            {
                throw new ArgumentOutOfRangeException("Error en X");
            }
            return _x;
        }
        private int VerificarY(int _y)
        {
            if (_y < 0 || _y > 50)
            {
                throw new ArgumentOutOfRangeException("Error en Y");
            }
            return _y;
        }

        //public int ObtenerX()
        //{
        //    return x;
        //}
        //public int ObtenerY()
        //{
        //    return y;
        //}
        //public void AsignarX(int _x)
        //{
        //    x= VerificarX(_x);
        //}
        //public void AsignarY(int _y)
        //{
        //    y = VerificarY(_y);
        //}
    }
}
