using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();
            //numeros.AddLast(3);
            for (int i = 1; i <= 10; i++)
            {
                numeros.AddFirst(i);
            }
            var primero= numeros.AddFirst(300);
            numeros.AddAfter(primero,200);
            numeros.AddBefore(primero,250);
            var nodo = numeros.First;
            while (nodo!=null) {
                Console.WriteLine(nodo.Value);
                nodo = nodo.Next;
            }
            for (var nodo2=numeros.Last;nodo!=null;nodo2=nodo2.Previous) {
                Console.WriteLine(nodo2.Value);
            }
            numeros.Remove(3);
            numeros.RemoveLast();
            numeros.RemoveFirst();
            //numeros.AddLast(200);
            foreach (var numero in numeros){
                Console.WriteLine(numero);
            }
            

            Console.ReadLine();
            //int[] numeroArreglo = new int[10];
            //numeroArreglo[2] = 20;
            //List<int> numerosLista = new List<int>();
            ////numerosLista.Add(20);
            //for (int i =1;i<=10;i++)
            //{
            //    numerosLista.Add(i);
            //}
            //numerosLista.Insert(numerosLista.Count-1,50);
            //numerosLista.Remove(4);
            //numerosLista.RemoveAt(0);
            //numerosLista.RemoveRange(0,3);
            ////numerosLista.Clear();

            //int numero = numerosLista[0];
            //foreach (var elemento in numerosLista)
            //{
            //    Console.WriteLine(elemento);
            //}

        }
    }
}
