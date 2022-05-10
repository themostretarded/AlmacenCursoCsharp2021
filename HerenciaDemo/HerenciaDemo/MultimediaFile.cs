using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class MultimediaFile
    {
        protected string tipoArchivo;
        public virtual string ObtenerTipo() {

            return "Archivo Multimedia";
        }
        protected void calcularTamaño() { }

        //string fechaCreacion, fechaModificacion, nombre, tipoElemento;
        //public virtual void DesplegarInformacion() {
        //    string informacion = fechaCreacion + " " + fechaModificacion + " " + nombre + " " + tipoElemento;
        //    Console.WriteLine(informacion);
        //   }

        //public override string ToString() {
        //    return "ToStringSobreescrito";
        //}

        //public MultimediaFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento)
        //{
        //    fechaCreacion = _fechaCreacion;
        //    fechaModificacion = _fechaCreacion;
        //    nombre = _nombre;
        //    tipoElemento = _tipoElemento;
        //}
    }
}
