using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Areas
{
    public  class Circle: Shape
    {
        public int radius;
        public Circle() 
        {
            radius = 0;
        }

        public override void setParam(int r)
        {
            this.radius = r;
        }
        public override double calculateArea()
        {
            double area = radius* radius* Math.PI;
            return area;
        }

    }
}
