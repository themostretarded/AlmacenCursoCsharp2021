using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracionesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rol tipoUsuario= Rol.Administraador;

            Console.WriteLine((int) tipoUsuario);

            if (tipoUsuario == Rol.Administraador)
            {
                tipoUsuario = tipoUsuario + 20;
            }

            Rol? tipoUsuario2 = null;

            string temporal = tipoUsuario.ToString();
            switch (tipoUsuario) {
                case Rol.Administraador: Console.WriteLine(tipoUsuario );
                    break;
                case Rol.Desarrollador: Console.WriteLine();
                    break;
                case Rol.UsuarioFinal: Console.WriteLine();
                    break;
            }
        }
    }
}
