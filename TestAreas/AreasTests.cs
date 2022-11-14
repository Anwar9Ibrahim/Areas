using Areas;
using System;

namespace TestAreas
{
    [TestClass]
    public class AreasTests
    {
        [TestMethod]
        public void AreasOfCircle()
        {
            int end = 10;
            double results;
            double check;
            dynamic circle = new Circle();
            for (int i = 1; i <= end; i++)
            {
                circle.setParam(i);
                check=circle.calculateArea();
                results = i * i * Math.PI;
                Assert.AreEqual(results, check, 0.001, "uncorrect Area");
            }
        }

        [TestMethod]
        public void AreasOfTriangle()
        {
            int end = 100;
            double results;
            double check;
            dynamic triangle = new Triangle ();
            int a, b, c;
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                a = rnd.Next(1, end);
                b = rnd.Next(1, end);
                c = rnd.Next(1, end);
                triangle.setParam(a,b,c);
                check = triangle.calculateArea();
                //check if numbers form a triangle 
                if (a + b > c && a + c > b && c + b > a)
                {
                    double s = (a + b + c) / 2;
                    results = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                }
                else
                {
                    results = 0;
                }
                Assert.AreEqual(results, check, 0.001, "uncorrect Area");
            }
        }
        [TestMethod]
        public void AreasOfRightTriangle()
        {
            int end = 100;
            bool results;
            bool check;
            dynamic triangle = new Triangle();
            int a, b, c;
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                a = rnd.Next(1, end);
                b = rnd.Next(1, end);
                c = rnd.Next(1, end);
                triangle.setParam(a, b, c);
                results = triangle.rightTriangle();
                //check if numbers form a triangle
                if (a + b > c && a + c > b && c + b > a)
                {
                    if (((a * a + b * b) == c * c) || ((a * a + c * c) == b * b) || ((c * c + b * b) == a * a))
                        check = true;
                    else
                        check = false;
                }
                else check = true;
                Assert.AreEqual(results, check, "uncorrect result");
            }
        }

    }
}