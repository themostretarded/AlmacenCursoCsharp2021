using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class ComparadorObjetos : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            int xHash = x.GetHashCode();
            int yHash = y.GetHashCode();
            if (xHash == yHash)
            {
                return 0;
            }
            if (xHash < yHash)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
