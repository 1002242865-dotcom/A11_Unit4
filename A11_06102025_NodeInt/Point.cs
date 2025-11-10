using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(int a)
        {
            this.x = a;
            this.y = a; 
        }

        public Point()
        {
            x = 10;
            y = 10;
        }

        public int getX()
        {
            return x;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public int getY()
        {
            return y;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }
}
