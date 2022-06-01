using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionRecursosDemo
{
    class FileManager: IDisposable
    {
        FileStream reader = null;
        public FileManager(string filePath)
        {
            //using (FileStream reader = File.Open(filePath,FileMode.Open)) {
            //    Byte[] b = new Byte[1024];
            //    UTF8Encoding temp = new UTF8Encoding();

            //    while (reader.Read(b, 0, b.Length) > 0)
            //    {
            //        Console.WriteLine(temp.GetString(b));
            //    }
            //}
            reader = File.Open(filePath, FileMode.Open);
                Byte[] b = new Byte[1024];
                UTF8Encoding temp = new UTF8Encoding();
                
                while (reader.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
           


        }
        //~FileManager() {
            
        //    System.Diagnostics.Trace.WriteLine("Archivo Cerrado");
        //}

        public void Dispose()
        {
            //el simbolo de pregunta si la referecnia es nula
            reader?.Dispose();
        }
    }
}
