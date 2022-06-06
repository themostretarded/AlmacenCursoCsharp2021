using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexadoresDemo
{
    struct Bits
    {
        int bits;
        public Bits(int _initialBits)
        {
            bits = _initialBits;
        }

        public int this[string nombre]
        {
            get { return 1; }
            set { }
        }
        public bool this[int index]
        {
            get => (bits & (1 << index)) != 0;

            set
            {
                if(value)
                {
                    bits |= (1 << index);
                }
                else
                {
                    bits &= ~(1 << index);
                }
            }
        }
        public override string ToString()
        {
            return (Convert.ToString(bits,2));
        }

    }
}
