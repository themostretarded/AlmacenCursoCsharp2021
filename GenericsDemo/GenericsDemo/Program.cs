using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola";
            object objeto = cadena;
            object x = 33;
            object y = 44;
            ComparadorObjetos comparadorObjetos = new ComparadorObjetos();
            IComparer<object> iComparador = comparadorObjetos;
            int resultado = iComparador.Compare(x,y);

            //Dato<int> dato = new Dato<int>();
            //IAlmacenador<int> almacenador = dato;
            //almacenador.SetDato(2);
            //IObtenedor<object> obtenedor = dato;
            //Console.WriteLine(obtenedor.GetDato());

            //Dato<string> dato = new Dato<string>();
            //IDato<object> datoTemporal = (IDato<object>)dato;
            
            //datoTemporal.SetDato("hola");
            //Console.WriteLine(datoTemporal.GetDato());

            //ClaseGenerica<ArgumentOutOfRangeException,string> g =
            //    new ClaseGenerica<ArgumentOutOfRangeException, string>(new ArgumentOutOfRangeException());
            ////g.HacerAlgo(3);
            //ClaseGenerica<Exception, Circulo> g2 =
            //    new ClaseGenerica<Exception,Circulo>(new Exception(""));
            //g2.HacerAlgo("yahoo");

            //Pila pila = new Pila(3);
            //pila.Apilar(1);
            //pila.Apilar(2);
            //pila.Apilar(3);

            //object elemento = pila.Desapilar();
            //Console.WriteLine(elemento);
            //elemento = pila.Desapilar();
            //Console.WriteLine(elemento);
            //elemento = pila.Desapilar();
            //Console.WriteLine(elemento);

            //Circulo c = new Circulo();
            //pila.Apilar(c);

            ////elemento = pila.Desapilar();
            //string cadena = (string)pila.Desapilar();

            //Circulo c2 =(Circulo) pila.Desapilar();
            //Console.WriteLine(elemento);
            Console.ReadLine();
        }
    }
}
