using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_06102025_NodeInt
{
    internal class Circle
    {
        private int r;
        private Point center;

        public Circle(int r, Point center)
        {
            this.r = r;
            this.center = center;
        }

        public int getR()
        {
            return r;
        }

        public void setR(int r)
        {
            this.r = r;
        }

        public Point getCenter()
        {
            return center;
        }

        public void setCenter(Point center)
        {
            this.center = center;
        }

        public override string ToString()
        {
             return "r:" + r + ", center:" + center;
        }
    }
}
