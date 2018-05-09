using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTS
{
    class Cost
    {
        public int[] tour=new int[100];
        int value;
        public Cost()
        {
            for (int i = 0; i < 100; i++)
                tour[i] = 0;
            value = 0;
        }
        public void setvalue(int n)
        {
            value = n;
        }
        public int getvalue()
        {
            return value;
        }
        public void settour(int n,int k)
        {
            tour[n] = k;
        }
    }
}
