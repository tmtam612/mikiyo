using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace baitoandonggoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] m = new int[100];
            Console.Write("nhập kích thước bình: "); int n = int.Parse(Console.ReadLine());
            try
            {
                StreamReader sr = new StreamReader("testfile.txt");              
                string[] s = sr.ReadLine().Trim().Split(' ');
                int max = int.MinValue;
                for (int i = 0; i < s.Length; i++)
                {
                    m[i] = Convert.ToInt32(s[i]);
                    if (m[i] > max)
                    {
                        max = m[i];
                    }
                }
                if (n >= max)
                {
                    baitoan bt = new baitoan(s.Length, m, n);
                    bt.sapxep();
                    bt.donggoi();
                    bt.result();
                }
                else
                {
                    Console.WriteLine("kích thước hộp nhỏ hơn vật cần đóng gói");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("không tìm được file đọc");
                throw ex;
            }
            Console.ReadKey();
        }
    }
}
