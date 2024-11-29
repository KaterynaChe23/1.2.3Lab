
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2_3
{
    class Program
    {
        static void Main()
        {
            TTriangle t1 = new TTriangle(5, 6, 3);
            TTriangle t2 = new TTriangle(5, 3, 6);
            Console.WriteLine(t1.ToString());

            Console.WriteLine();

            TTrianglePrizm prizm1 = new TTrianglePrizm(5, 7, 6, 11);
            TTrianglePrizm prizm2 = new TTrianglePrizm(7, 5, 6, 11);
            Console.WriteLine(prizm1.ToString());

            Console.WriteLine();

            Console.WriteLine($"Трикутники рівніміж собою:{t1.Comparison(t2)}");

            TTriangle scaledTriangle = t1 * 5;
            TTriangle scaledTriangle1 = 5 * t1;
            Console.WriteLine($"Множення сторони трикутник на число:a = {scaledTriangle.a_}, b = {scaledTriangle.b_}, c = {scaledTriangle.c_}");
            Console.WriteLine($"Множення числа на сторони трикутник :a = {scaledTriangle1.a_}, b = {scaledTriangle1.b_}, c = {scaledTriangle1.c_}");

            Console.WriteLine();

            Console.WriteLine($"Призми рівні між собою:{prizm1.Comparison(prizm2)}");

            TTrianglePrizm scaledTrianglePrizm = prizm1 * 5;
            TTrianglePrizm scaledTrianglePrizm1 = 5 * prizm1;
            Console.WriteLine($"Множення параметрів призми на число:: a = {scaledTrianglePrizm1.a_}, b = {scaledTrianglePrizm1.b_}, c = {scaledTrianglePrizm1.c_}, h = {scaledTrianglePrizm1.h_}");
            Console.WriteLine($"Множення числа на параметри  призми: a = {scaledTrianglePrizm1.a_}, b = {scaledTrianglePrizm1.b_}, c = {scaledTrianglePrizm1.c_}, h = {scaledTrianglePrizm1.h_}");

        }

    }
}
