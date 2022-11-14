// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            dynamic shape = new Circle();

            int r = 5;
            shape.setParam(r);
            Console.WriteLine(shape.calculateArea());

            dynamic shape2 = new Triangle();
            int a = 6;
            int b = 10;
            int c = 8;
            shape2.setParam(a,b,c);
            Console.WriteLine(shape2.calculateArea());
            int end = 100;
            bool results;
            bool check;
            dynamic triangle = new Triangle();
            Random rnd = new Random();
            
            for (int i = 1; i <= 10; i++)
            {
                a = rnd.Next(1, end);
                b = rnd.Next(1, end);
                c = rnd.Next(1, end);
                triangle.setParam(a, b, c);
                results = triangle.rightTriangle();
                if (a + b > c && a + c > b && c + b > a)
                {
                    if (((a * a + b * b) == c * c) || ((a * a + c * c) == b * b) || ((c * c + b * b) == a * a))
                        check = true;
                    else
                        check = false;
                }
                else check = true;
                Console.WriteLine("result  expected: "+results.ToString()+"got check= "+ check.ToString()+"where a is  "+ a.ToString()+" b "+ b.ToString()+"  c  "+c.ToString());
            }
            }

    }
}
