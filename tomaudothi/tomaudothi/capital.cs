using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomaudothi
{
    class capital
    {
        int level;
        int color;
        string name;
        int position;
        public capital()
        {
            level = 0;
            color = 0;
            name = "";
            position = 0;
        }
        public capital(int n, int m)
        {
            level = n;
            color = 0;
            name = "";
            position = m;
        }
        public void setname(string n)
        {
            name = n;
        }
        public string getname()
        {
            return name;
        }
        public void setlevel(int n)
        {
            level = n;
            
        }
        public int getlevel()
        {
            return level;
        }
        public void setcolor(int m)
        {
            color = m;
        }
        public int getcolor()
        {
            return color;
        }
        public void setposition(int n)
        {
            position = n;
        }
        public int getposition()
        {
            return position;
        }
    }
}
