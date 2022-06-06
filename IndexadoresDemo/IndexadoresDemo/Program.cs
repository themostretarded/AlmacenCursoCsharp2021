using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexadoresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int binData = 0b0_00000000_00000000_00000000_00000000;
            Console.WriteLine(binData);

            Bits bits = new Bits(binData);

            bool dato = bits[0];
            Console.WriteLine(dato);

            bits["prueba"] = 2;

            bits[0] = true;
            dato = bits[0];
            Console.WriteLine(dato);

            //uint binData2 = 0b0_00000000_00000000_00000000_00001111;
            //var uno = 0b0_00000001;
            //var desplazamiento = uno<<7;
            //10000000
            //var resultado = (binData&desplazamiento) !=0;
            //var resultado = (binData & (1<<7)) != 0;


            //xor
            //uint result = binData ^ binData2;
            //and
            //uint result = binData & binData2;
            //or
            //uint result = binData | binData2;
            //LEFT SHIFT(<<)
            //RIGHT SHIFT(>>)
            //uint result = binData >> 2;
            //NOT uint result = ~binData;
            //Console.WriteLine(result);

            //Console.WriteLine(Convert.ToString(result, 2));
            //Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}
