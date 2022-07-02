using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventosDemo
{
    class Program
    {
        //static void Accion1(int num1, int num2, int num3, int num4) { }
        //static string funcion1() { return "hola"; }
        //static string funcion1(string dato1,int dato2,bool dato3) { return "hola"; }
        static void Main(string[] args)
        {
            //List<int> numeros = new List<int> {
            //20,133,89,23,78,382};

            //var promedio = numeros.Average(x => x);
            //var cuenta = numeros.Count(x=> x>50&&x<100);
            //var suma = numeros.Sum(x => x % 5 == 0 ? x : 0);

            //SistemaLuces luces = new SistemaLuces();
            //Action action = new Action(luces.ApagarLuces);
            //Action<int, int, int, int> action2 = new Action<int, int, int, int>(Accion1);

            //Func<string> funcion = new Func<string>(funcion1);
            //Func<string, int, bool, string> funcion2 = new Func<string, int, bool, string>(funcion1);
            CentralHub hub = new CentralHub();
            SistemaLuces luces = new SistemaLuces();
            SistemaAlarmas alarmas = new SistemaAlarmas();
            SistemaElectrodomestico electrodomesticos = new SistemaElectrodomestico();

            hub.Add(()=>luces.ApagarLuces(5));
            hub.Add(alarmas.EncenderAlarmas);
            hub.Add(electrodomesticos.ApagarElectrodomesticos);

            hub.ChecarSalida();
            hub.ChecarSalida();
            hub.ChecarSalida();
            hub.ChecarSalida();
            hub.ChecarSalida();
            Console.ReadLine();
        }
        //static bool Contiene(string nombre) { return nombre.Contains("H"); }
    }
}
