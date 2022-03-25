using System;

namespace MetodosDemo
{
    internal class Program
    {
        static string nombre = "panchito";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(RegresarDatos());
            BorrarConsola();
            int cociente = 0;
            int residuo = 0;
            (cociente, residuo) = dividir(50, 25);
            Console.WriteLine("cociente:" + cociente);
            Console.WriteLine("residuo:" + residuo);
            Saludar(nombre);
            nombre = "juan";
            Saludar(nombre);
            //segunda forma de recuperar info con tuplas
            (int cociente, int residuo) data = dividir(100, 50);
            Console.WriteLine("cociente:" + data.cociente);
            Console.WriteLine("residuo:" + data.residuo);

            Console.WriteLine(Sumar2(cociente,residuo));
            Console.ReadLine();
            BorrarConsola();

            
        }

        static void BorrarConsola() {
            Console.ReadLine();
            Console.Clear ();
            Console.Beep ();
        }
        //mas tuplas
        static (int, int) dividir( int numero1, int numero2) 
        {
            int cociente = numero1 / numero2;
            int residuo = numero1 % numero2;
            return (cociente, residuo); 
        }

        //tuplas
        static (int, int) RegresarDatos()
        {
            return (8, 3);
        }

        //metodo con cuerpo de expresion
        static void Saludar(string nombre)=> Console.WriteLine("texto feo--"+nombre);
        static int Sumar2(int numero1, int numero2) => numero1 + numero2;

    }
}
