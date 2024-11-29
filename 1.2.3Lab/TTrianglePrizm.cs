using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2_3
{
    public class TTrianglePrizm : TTriangle
    {

        // поле висот призми
        private double h;
        public TTrianglePrizm() : base()
        {
            this.h = 0;
        }
        public TTrianglePrizm(double a, double b, double c, double h) : base(a, b, c)
        {
            if (h <= 0)
                throw new Exception("Висота має бути додатнім числом.");

            this.h = h;
        }
        public TTrianglePrizm(TTrianglePrizm other) : base(other.a_, other.b_, other.c_)
        {

            this.h = other.h;
        }

        public double h_
        {
            get { return h; }
            set { h = value; }
        }
        public new double Area()
        {
            double sideS = h_ * base.Perimeter();
            double areaPrizm = sideS + 2 * base.Area();
            return areaPrizm;
        }

        //метод знаходження об'єму призми
        public double PrizmVolume()
        {
            return h * base.Area();
        }
        public new bool Comparison(TTrianglePrizm other)
        {
            return base.Comparison(other) && h == other.h;
        }
        public static TTrianglePrizm operator *(TTrianglePrizm p, double num)
        {
            TTrianglePrizm temp = new TTrianglePrizm(p.a_ * num, p.b_ * num, p.c_ * num, p.h_ * num);
            return temp;
        }
        public static TTrianglePrizm operator *(double num, TTrianglePrizm p)
        {
            TTrianglePrizm temp = new TTrianglePrizm(p * num);
            return temp;
        }


        public override string ToString()
        {
            return $" висота призми = {h}\n" +
                $"Об'єм призми:{PrizmVolume()}\n" +
                $"Загальна площа призми:{Area()} ";
        }
    }
}

