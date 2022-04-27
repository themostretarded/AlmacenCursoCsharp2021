using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposValorTiposReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //int valor1 = 50;
            //int valor2 = valor1;
            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);
            //valor1++;

            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);
            ///*Console.ReadLine();*/
            //int numero1 = 0;
            //agregarUno(numero1);
            //Circulo circulo = new Circulo();
            //circulo.radio = 10;
            //agregarUno(circulo);

            //Circulo circulo = new Circulo();

            //if (circulo !=null) {
            //    Console.WriteLine(circulo.radio);
            //    circulo.radio = 50;
            //}
            //Equivale al if de arriba porque pregunta si no es nulo osea si esta inicializado
            //Console.WriteLine(circulo?.radio);

            //int? i = null;

            //i = 10;

            //int? j = 0;

            //j = i;

            //if (!i.HasValue)
            //{
            //    i = 10;
            //}
            //else {
            //    Console.WriteLine(i.Value);
            //}

            //int numero1 = 10;
            //agregarUno(ref numero1);

            //int numero2;
            //agregarUno(out numero2);
            //int.TryParse("hola", out int pruebaconversion1);
            //Console.WriteLine(pruebaconversion1);

            int valor = 50;
            object objeto = valor;
            int otrovalor = (int)objeto;

            if (objeto is int) {
                Console.WriteLine(objeto);
            }else if (objeto is Circulo) {
                Circulo circulo = (Circulo)objeto;
                Console.WriteLine(objeto);
            }

            string valor2 = objeto as string;
            Console.WriteLine(objeto);

            Console.ReadLine();
        }
        public static void agregarUno(out int Param1)
        {
            Param1 = 0;
            Param1++;
        }

        public static void agregarUno(Circulo circulo)
        {
            circulo = new Circulo();
            circulo.radio=50;
        }

    }
}
