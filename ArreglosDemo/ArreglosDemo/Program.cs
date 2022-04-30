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


            Circulo[] circulos = {new Circulo(20),
                new Circulo(5) };

            var cadenas = new[] {2,2,3,2.54 };
            var personas = new[] {new{Nombre ="ada" },
                new{ Nombre="hector"}
                };

            try {
                int numero3 = numeros[10];
            }
            catch {
                Console.WriteLine("Indice incorrecto");
            }
        }
    }
}
