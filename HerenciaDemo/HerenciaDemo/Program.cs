using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MultimediaFile multimedia;
            //DynamicFile dFile = new DynamicFile();
            //StaticFile sFile = new StaticFile();
            //otherFile oFile = new otherFile();

            //multimedia = dFile;
            //Console.WriteLine(multimedia.ObtenerTipo());
            //multimedia = sFile;
            //Console.WriteLine(multimedia.ObtenerTipo());
            //multimedia = oFile;
            //Console.WriteLine(multimedia.ObtenerTipo());
            string prueba = "Esta es una demo de los metodos de extension";
            //var cantidad1 = MetodosExtension.ContarPalabras(prueba);

            var cantidad2 = prueba.ContarPalabras(' ');

            //Console.WriteLine(cantidad1);
            Console.WriteLine(cantidad2);

            Console.ReadLine();
            //MultimediaFile mFile = new MultimediaFile();
            //mFile.DesplegarInformacion();
            //Console.WriteLine(mFile);
            //mFile.ToString();
            //DynamicFile dynFile = new DynamicFile();
            //dynFile.DesplegarInformacion();
            //dynFile.DesplegarInformacion();
            //StaticFile staticFile = new StaticFile();
            //staticFile.DesplegarInformacion();
            //staticFile.DesplegarInformacion();
            //MultimediaFile mFile2 = staticFile;
            //StaticFile sFile2 = mFile2 as StaticFile;
            //if (mFile2 != null) {
            //    sFile2.DesplegarInformacion();
            //}            
            //object objeto1 = mFile;            
        }
    }
}
