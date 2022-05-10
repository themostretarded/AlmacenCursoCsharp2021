using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class DynamicFile : MultimediaFile
    {
        public override string ObtenerTipo()
        {
            calcularTamaño();
            string tArchivo = tipoArchivo;
            //string.ContarPalabras();
            return "archivo dinamico";
        }
        //public DynamicFile(string _fechaCreacion, string _fechaModificacion,
        //                    string _nombre, string _tipoElemento)
        //    : base(_fechaCreacion, _fechaModificacion, _nombre, _tipoElemento)
        //{ }

        //public DynamicFile(string _nombre) { }
        //string duracion;
        //public override void DesplegarInformacion()
        //{
        //    Console.WriteLine("Soy un archivo dinamico");
        //}
        //public virtual void Reproducir() {
        //    Console.WriteLine("Reproduciendo");
        //}
        //public virtual void Pausar()
        //{
        //    Console.WriteLine("Pausar");
        //}
        //public virtual void Detener()
        //{
        //    Console.WriteLine("Detener");
        //}
    }
}
