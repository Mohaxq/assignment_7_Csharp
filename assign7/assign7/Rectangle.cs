using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign7
{
    internal class Rectangle
    {
        private int x;
        private int y;
        public Rectangle()
        {
            x = 0;
            y = 0;
        }
        public Rectangle(int length, int breadth)
        {
            x = length;
            y = breadth;
        }
        public Rectangle(int z)
        {
            x = z;
            y = z;
        }
    }
}
