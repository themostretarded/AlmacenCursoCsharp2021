﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionRecursosDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileManager manager1 = new FileManager(@"C:\Users\Meer\Desktop\redaccion.txt"))
            {
            }

            using (FileManager manager2 = new FileManager(@"C:\Users\Meer\Desktop\redaccion.txt"))
            {
            }

            //FileManager manager2 = new FileManager(@"C:\Users\Meer\Desktop\redaccion.txt");
            Console.ReadLine();
        }
    }
}
