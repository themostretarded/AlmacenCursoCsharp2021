using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDemo
{
    //class PrinterDerivada : Printer2 {
    //    public override int x { get=>base.X }
    //}
    class Printer2 : IPrinter
    {
        int IPrinter.X
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
