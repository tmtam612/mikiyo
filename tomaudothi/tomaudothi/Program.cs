using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace tomaudothi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] a = new int[100, 100];
            int n;
            Console.WriteLine("nhập số đỉnh ");n = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập ma trận: ");
            for(int i=0;i<n;i++)
            {
                String[] m = Console.ReadLine().Trim().Split(' ');
                for (int j=0;j<n;j++)
                {
                    a[i, j] = Convert.ToInt32(m[j]);
                }
            }
                node bt = new node(a, n);
                bt.sapxep();
                bt.tomau();
                bt.result();
            Console.ReadKey();
        }
    }
}
