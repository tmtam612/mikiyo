using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace tomaudothi
{
    class node
    {
        capital[] mang;
        int[,] matran;
        int length;
        string[] dinh = {"Paris","Lisbon","Madrid","Viene","Berlin","Rome","Hague","Beme","Brusels","Luxemburg" };
        public node(int [,] a,int n)
        {
            mang = new capital[n];
            matran = new int[n,n];
            length = n;
            for (int i = 0; i < length; i++)
            {
                mang[i] = new capital();
                mang[i].setname(dinh[i]);
                mang[i].setposition(i);
                mang[i].setcolor(0);
                for (int j = 0; j < length; j++)
                {
                    if (a[i, j] > 0)
                    {
                        mang[i].setlevel(mang[i].getlevel()+a[i, j]);
                    }
                }
            }
           for(int i=0;i<length;i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matran[i, j] = a[i, j];
                }
            }
        }
        public int check()
        {
            for(int i=0;i<length;i++)
            {
                if (mang[i].getcolor() == 0) return i;
            }
            return -1;
        }
        public int check(int n)
        {
            for(int i=0;i<length;i++)
            {
                if (mang[i].getposition() == n) return i;
            }
            return -1;
        }
        public void tomau()
        {
            int color = 1;
            mang[0].setcolor(color);
            for(int i=0;i<length-1;i++)
            { 
                for(int j=i+1;j<length;j++)
                {
                    if (matran[mang[i].getposition(), mang[j].getposition()] < 0 && mang[j].getcolor() == 0)
                    {
                        int flag = 0;
                        for (int u = 0; u < length; u++)
                        {
                            if (matran[mang[u].getposition(), mang[j].getposition()] == 1)
                            {
                                if (mang[u].getcolor() == mang[i].getcolor())
                                {
                                    mang[j].setcolor(0);
                                    flag = 1;
                                    u = length;
                                }
                            }
                        }
                        if (flag == 0) mang[j].setcolor(color);
                    }
                }

                int k = check();
                if(k!=-1)
                {
                    color++;
                    mang[k].setcolor(color);
                    i = k - 1;
                }                
            }
            Console.WriteLine(color+" màu");
        }
        static void Swap<T>(ref T x,ref T y)
        {
            T t = y;
            y = x;
            x = t;
        }
        public void sapxep()
        {
            bool flag = true;
            for (int i = 1; (i <= (length - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (length - 1); j++)
                {
                    if (mang[j + 1].getlevel() > mang[j].getlevel())
                    {
                        Swap(ref mang[j + 1], ref mang[j]);
                        flag = true;
                    }
                }
            }
        }
        
        public void result()
        {
            Console.Write("màu 1:");
            for (int i = 0; i < length; i++)
            {
                if (mang[i].getcolor() == 1)
                {
                    Console.Write(mang[i].getname() + " ");
                }
            }
            Console.WriteLine();
            Console.Write("màu 2:");
            for (int i = 0; i < length; i++)
                if (mang[i].getcolor() == 2) Console.Write(mang[i].getname() + " ");
            Console.WriteLine();
            Console.Write("màu 3:");
            for (int i = 0; i < length; i++)
                if (mang[i].getcolor() == 3) Console.Write(mang[i].getname() + " ");
            Console.WriteLine();
            Console.Write("màu 4:");
            for (int i = 0; i < length; i++)
                if (mang[i].getcolor() == 4) Console.Write(mang[i].getname() + " ");
            Console.WriteLine();
        }
    }

}
