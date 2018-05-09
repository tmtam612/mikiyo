using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitoandonggoi
{
    class Box
    {
        int binh;
        int value;
        public Box()
        {
            binh = 0;
            value = 0;
        }
        public Box(int n,int m)
        {
            binh = n;
            value = m;
        }
        public void setvalue(int m)
        {
            value = m;
        }
        public int getvalue()
        {
            return value;
        }
        public void setbinh(int n)
        {
            binh = n;
        }
        public int getbinh()
        {
            return binh;
        }
    }
}
