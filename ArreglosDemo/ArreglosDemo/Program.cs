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
            //Inicializador de un arreglo
            //int[] numeros = new int[4];
            //Declaracion de arreglo

            int[] numeros = {211,2,2,3 };
            for (int i=0;i<numeros.Length;i++)
            { 
                Console.WriteLine(numeros[i]);
            }

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Circulo[] circulos = {new Circulo(20),
                new Circulo(5) };
            foreach (var circulo in circulos)
            {
                Console.WriteLine(circulo.radio);
            }
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
        }
    }
}
