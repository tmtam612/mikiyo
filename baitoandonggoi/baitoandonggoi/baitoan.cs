using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitoandonggoi
{
    class baitoan
    {
        Box[] mang;
        int[] temp;
        int size;
        int length;
        int box = 1;
        public baitoan()
        {
            length = 0;
            mang = new Box[100];
            temp = new int[100];
            for (int i = 0; i < length; i++)
            {
                mang[i].setvalue(0);
                temp[i] = 0;
            }
            size = 0;
        }
        public baitoan(int a, int[] b, int c)
        {
            length = a;
            mang = new Box[100];
            temp = new int[100];
            for (int i = 0; i < length; i++)
            {
                mang[i]=new Box(0,b[i]);
                temp[i] = 1;
            }
            size = c;
        }
        public void swap<T>(ref T a, ref T b)
        {
            T temp = b;
            b = a;
            a = temp;
        }
        public void sapxep()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (mang[i].getvalue() < mang[j].getvalue())
                    {
                        swap(ref mang[i], ref mang[j]);
                    }
                }
            }
        }
        public void donggoi()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (mang[i].getvalue() + mang[j].getvalue() == size && temp[j] != 0 && temp[i] != 0)
                    {
                        temp[i] = 0;
                        temp[j] = 0;
                        mang[j].setbinh(box);
                        mang[i].setbinh(box);
                        box++;
                        j = length - 1;
                    }       
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (temp[i] != 0)
                {
                    mang[i].setbinh(box);
                    int sum = mang[i].getvalue();
                    for (int j = length - 1; j > i; j--)
                    {
                        if (temp[j] != 0 && sum + mang[j].getvalue() <= size)
                        {
                            sum = sum + mang[j].getvalue();
                            temp[j] = 0;
                            mang[j].setbinh(box);
                        }
                    }
                    box++;
                }
            }          
        }
        public void result()
        {
            Console.WriteLine("Kết quả xếp vào: " + (box - 1) + " hộp");
            for (int i = 1; i <= box - 1; i++)
            {
                Console.Write("bình " + i + ":");
                for (int j = 0; j < length; j++)
                {
                    if (mang[j].getbinh() == i)
                    {
                        Console.Write(mang[j].getvalue() + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
