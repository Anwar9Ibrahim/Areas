using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Triangle:Shape
    {
        public int a;
        public int b;
        public int c;

        public Triangle()
        { 
            a= 0;
            b= 0;
            c= 0;
        }
        
        public override void setParam(int a_, int b_, int c_)
        {
            //check if it is a triangle
            if (a_ + b_ > c_ && a_ + c_ > b_ && c_ + b_ > a_)
            {
                a = a_;
                b = b_;
                c = c_;
            }
            else
            {
                Console.WriteLine("numbers don't form a triangle");
                a = 0;
                b= 0;
                c= 0;
            }
                
        }

        public override double calculateArea()
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public bool rightTriangle()
        {
            if(((a * a + b * b) == c * c) || ((a * a + c * c) == b * b)|| ((c * c + b * b) == a * a))
                    return true;
            return false;
        }

    }
}
