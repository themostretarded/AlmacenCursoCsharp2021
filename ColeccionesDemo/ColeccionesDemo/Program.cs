using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesDemo
{
    class Cliente {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    ID=1,
                    Nombre="Hector"
                },
                new Cliente
                {
                    ID=2,
                    Nombre="Ricardo"
                },
                new Cliente
                {
                    ID=3,
                    Nombre="Santiago"
                },
            };
            var cliente = clientes.Find((Cliente c) =>{
                return c.ID == 20;
            });
            if (cliente != null) { Console.WriteLine(cliente.Nombre); } else { Console.WriteLine("no lo encontre"); }
            Console.WriteLine(cliente.Nombre);

            Console.ReadLine();
            
        }

    }
}












//Dictionary<int, int> diccionario = new Dictionary<int, int>();
//Dictionary<string, string> frases = new Dictionary<String, String>();
//frases.Add("compayito", "pico revoloteo y ataco");
//frases.Add("Pajaro ", "Tieso");
//foreach (var elemento in frases)
//{
//    string autor = elemento.Key;
//    string frase = elemento.Value;
//    //cadena interpolada
//    Console.WriteLine($"{autor},{frase}");
//}

//frases["compayito"] = "sir cuncesion";
//foreach (var elemento in frases)
//{
//    string autor = elemento.Key;
//    string frase = elemento.Value;
//    //cadena interpolada
//    Console.WriteLine($"{autor},{frase}");
//}
//for (int i=1;i<=10;i++)
//{
//    diccionario.Add(i,i);
//}

//Stack<int> numeros = new Stack<int>();
//for (int i = 1; i <= 10; i++)
//{
//    numeros.Push(i);
//}
//var elemento = numeros.Pop();
//while (numeros.Count > 0)
//{
//    Console.WriteLine(numeros.Pop());
//}
//foreach (var numero in numeros) 
//{
//    Console.WriteLine(numero);
//}
//Queue<int> numeros = new Queue<int>();
////numeros.Enqueue(1);
//for (int i =1;i<=10;i++) {
//    numeros.Enqueue(i);
//}
//var elemento = numeros.Dequeue();
//while (numeros.Count >0)
//{
//    Console.WriteLine(numeros.Dequeue());
//}
////foreach (var numero in numeros) 
////{
////    Console.WriteLine(numero);
////}
//LinkedList<int> numeros = new LinkedList<int>();
////numeros.AddLast(3);
//for (int i = 1; i <= 10; i++)
//{
//    numeros.AddFirst(i);
//}
//var primero= numeros.AddFirst(300);
//numeros.AddAfter(primero,200);
//numeros.AddBefore(primero,250);
//var nodo = numeros.First;
//while (nodo!=null) {
//    Console.WriteLine(nodo.Value);
//    nodo = nodo.Next;
//}
//for (var nodo2=numeros.Last;nodo!=null;nodo2=nodo2.Previous) {
//    Console.WriteLine(nodo2.Value);
//}
//numeros.Remove(3);
//numeros.RemoveLast();
//numeros.RemoveFirst();
////numeros.AddLast(200);
//foreach (var numero in numeros){
//    Console.WriteLine(numero);
//}
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

//HashSet<string> Licenciatura1 = new HashSet<string>();
//Licenciatura1.Add("Cocina");
//Licenciatura1.Add("Negociios");
//Licenciatura1.Add("Programacion");
//Licenciatura1.Add("Postres");
//HashSet<string> Licenciatura2 = new HashSet<string>(new string[] { "Programacion","Algoritmos","Postres","BD"});
//foreach (var elemento in Licenciatura1) {
//    Console.WriteLine(elemento);
//}
//Console.WriteLine("antes de los metodos");
//Licenciatura1.IntersectWith(Licenciatura2);
//Licenciatura1.UnionWith(Licenciatura2);
//Licenciatura1.ExceptWith(Licenciatura2);
//foreach (var elemento in Licenciatura1)
//{
//    Console.WriteLine(elemento);
//}
//SortedList<string, string> nombres = new SortedList<string, string>();
//nombres.Add("z", "ZACK");
//nombres.Add("a", "ALBERTO");
//nombres.Add("h", "HECTOR");
//nombres.Add("b", "BRAULIO");

//foreach (var elemento in nombres)
//{
//    string inicial = elemento.Key;
//    string nombre = elemento.Value;
//    Console.WriteLine($"{inicial}: {nombre}");
//}

//List<string> elementos = new List<string>
//{
//    "Hecotr",
//    "Ricardo",
//    "Juan"
//};
//Dictionary<int, int> valores = new Dictionary<int, int> {
//    [0] = 1,
//    [1] = 2,
//    [2] = 3,
//};
//Dictionary<string, string> nombres = new Dictionary<string, string> {
//    {"hp","hector lopez" },
//    {"rp","ricardo perez" }
//};
