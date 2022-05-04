using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (args.Length > 0)
            //{
            //    foreach (var parametro in args)
            //    {
            //        Console.WriteLine(parametro);
            //    }
            //}

            //Inicializador de un arreglo
            //int[] numeros = new int[4];
            //Declaracion de arreglo

            //int[] numeros = {211,2,2,3 };
            //for (int i=0;i<numeros.Length;i++)
            //{ 
            //    Console.WriteLine(numeros[i]);
            //}

            //foreach (var numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //Circulo[] circulos = {new Circulo(20),
            //    new Circulo(5) };
            //foreach (var circulo in circulos)
            //{
            //    Console.WriteLine(circulo.radio);
            //}
            //var cadenas = new[] {2,2,3,2.54 };
            //var personas = new[] {
            //    new{Nombre ="ada" },
            //    new{ Nombre="hector"}
            //    };
            //var tipo = numeros.GetType();


            //try 
            //{
            //    int numero3 = numeros[10];
            //}
            //catch 
            //{
            //    Console.WriteLine("Indice incorrecto");
            //}

            int[] arreglo = {3,5,3,2 };
            int[] arreglo2 = (int [])arreglo.Clone();
            //int[] arreglo2 = new int[arreglo.Length];

            //Array.Copy(arreglo, arreglo2, arreglo.Length);
            //for (int i=0;i<arreglo.Length; i++)
            //{
            //    arreglo2[i]=arreglo[i];
            //}
            Console.WriteLine(arreglo[0]);
            Console.WriteLine(arreglo2[0]);
            arreglo[0] = 50;
            Console.WriteLine(arreglo[0]);
            Console.WriteLine(arreglo2[0]);
            int[,] bidimensional = new int[5, 5];
            bidimensional[0,0] = 1;
            bidimensional[3,3] = 10;
        }

        static void GenerarReporte(int[] datos) { 
        
        }
        static int[] Inicializar()
        { 
            Console.WriteLine("Numero de elementos");
            string respuesta = Console.ReadLine();
            int cantidad = int.Parse(respuesta);
            int[] numeros = new int[cantidad];
            for (int i=0;i<cantidad;i++)
            {
                Console.WriteLine("Valor para el elemento");
                respuesta = Console.ReadLine();
                int dato = int.Parse(respuesta);
                numeros[i] = dato;
            }
            return numeros;
        }
    }
}
