
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2_3
{
    public class TTriangle
    {
        private double a, b, c;


        public TTriangle()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public TTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Сторони трикутника мають бути додатними числами.");
            }

            if (!(a + b > c && b + c > a && a + c > b))
            {
                throw new Exception("Задані сторони не можуть утворити трикутник.");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public TTriangle(TTriangle other)
        {
            this.a = other.a;
            this.b = other.b;
            this.c = other.c;
        }
        public double a_
        {
            get { return a; }
            set { a = value; }
        }
        public double b_
        {
            get { return b; }
            set { b = value; }
        }
        public double c_
        {
            get { return c; }
            set { c = value; }
        }

        public double Area()
        {

            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        // порівняння з іншими трикутниками

        public bool Comparison(TTriangle other)
        {

            double[] sides1 = { a, b, c };
            Array.Sort(sides1);

            double[] sides2 = { other.a, other.b, other.c };
            Array.Sort(sides2);

            return sides1[0] == sides2[0] && sides1[1] == sides2[1] && sides1[2] == sides2[2];
        }




        public static TTriangle operator *(TTriangle t, double num)
        {
            TTriangle temp = new TTriangle(t.a * num, t.b * num, t.c * num);
            return temp;
        }
        public static TTriangle operator *(double num, TTriangle t)
        {
            TTriangle temp = new TTriangle(t * num);
            return temp;

        }
        public override string ToString()
        {
            return $"Трикутник  зі сторонами: a = {a}, b = {b}, c = {c}\n" +
                $"Площа трикутника:{Area()}\n" +
                $"Периметир трикутника:{Perimeter()}";

        }

    }
}