using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTS
{
    class node
    {
        int[,] mang;
        int length;
        Cost cost;
        char[] dinh = {'A','B','C','D','E'};
        public node(int n,int[,] a)
        {
            mang = new int[100, 100];      
            length = n;
            for(int i=0;i<length;i++)
                for(int j=0;j<length;j++)
                    mang[i, j] = a[i, j];
        }
        public int timduongdi(int start)
        {   
            int[] temp = new int[100];
            cost=new Cost();
            int count = 0;
            int t = -1;
            int k = 0, h = start;
            for (int i = 0; i < length; i++)
                temp[i] = 1;
            temp[h] = 0;
            cost.settour(count, h);
            for (int i = 0; i < length-1; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < length; j++)
                {
                    if (mang[h, j] < min && mang[h, j] > 0 && temp[j] == 1)
                    {
                        min = mang[h, j];
                        t = j;

                    }
                }
                h = t;
                cost.setvalue(cost.getvalue() + min);
                count++;
                cost.settour(count, h);
                temp[h] = 0;
            }
            for (int i = 0; i < length; i++)
            {
                if (temp[i] == 1)
                {
                    k++;
                }
            }
            if(k>0)
            {
                return 0;
            }
            else
            {
                if (mang[h, start] < 0) return 0 ;
                else
                {
                    cost.setvalue(cost.getvalue() + mang[h, start]);
                    count++;
                    cost.settour(count, start);                  
                    return cost.getvalue();                 
                }
            }
        }
        public void result()
        {
            int[] b = new int[100];int min = timduongdi(0);int k = 0;
            for(int i=1;i<length;i++)
            {
                if(timduongdi(i)<min)
                {
                    min = timduongdi(i);
                    k = i;
                    b =cost.tour ;
                }
            }
            Console.Write("Kết quả: Tour {");
            for(int i=0;i<length;i++)
            Console.Write(dinh[b[i]]+",");
            Console.Write(dinh[b[length]]+"}");
            Console.WriteLine();
            Console.WriteLine("Cost= " + min);
        }     
    }
}
