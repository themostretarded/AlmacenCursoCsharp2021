using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    //class otherFile : StaticFile {
    //    public override void DesplegarInformacion()
    //    {
    //        base.DesplegarInformacion();
    //    }
    //}

    class StaticFile:MultimediaFile
    {

        public override string ObtenerTipo()
        {
            return "archivo estatico";
        }

        //public staticfile(string _fechacreacion, string _fechamodificacion,
        //                    string _nombre, string _tipoelemento)
        //    : base(_fechacreacion, _fechamodificacion, _nombre, _tipoelemento)
        //{ }
        //public override void DesplegarInformacion()
        //{
        //    Console.WriteLine("Soy un archivo estatico");
        //}
        //public virtual void Editar() {
        //    Console.WriteLine("editando");
        //}
    }
}
