using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexadoresDemo
{

    class Bits3 : Bits2 
    {
        public override bool this[int index] { get => base[index]; set => base[index] = value; }
    }

    class Bits2 : IIndexadorBase
    {
         bool IIndexadorBase.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    internal interface IIndexadorBase
    {
        bool this[int index]
        {
            get;
            set;
        }
    }
}
