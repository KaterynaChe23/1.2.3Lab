using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1_2_3;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestProject
{
    [TestClass]
    public class TTriangleTests
    {
        [TestMethod]
        public void Сonstructor_ParametersSidesToZero()
        {

            TTriangle triangle = new TTriangle();

            Assert.AreEqual(0, triangle.a_, "Значення а має дорівнювати 0");
            Assert.AreEqual(0, triangle.b_, "Значення b має дорівнювати 0");
            Assert.AreEqual(0, triangle.c_, "Значення c має дорівнювати 0");
        }
        [TestMethod]
        public void Constructor_With_Parameter_Options()
        {
            TTriangle triangle1 = new TTriangle(5, 6, 7);

            Assert.AreEqual(5, triangle1.a_, "Сторона а не відповідає своєму параметру");
            Assert.AreEqual(6, triangle1.b_, "Сторона b не відповідає своєму параметру");
            Assert.AreEqual(7, triangle1.c_, "Сторона c не відповідає своєму параметру");
        }

        [TestMethod]
        public void TTriangle_CannotBeCreated_WithInvalidSides()
        {

            double a = 1;
            double b = 2;
            double c = 3;


            var exception = Assert.ThrowsException<Exception>(() => new TTriangle(a, b, c));
            Assert.AreEqual("Задані сторони не можуть утворити трикутник.", exception.Message);
        }
        [TestMethod]
        public void Copy_Constructor()
        {
            TTriangle originalTriangle = new TTriangle(5, 6, 7);

            TTriangle copy = new TTriangle(originalTriangle);

            Assert.AreEqual(originalTriangle.a_, copy.a_, "Конструктор копіювання не копіює дані");
            Assert.AreEqual(originalTriangle.b_, copy.b_, "Конструктор копіювання не копіює дані");
            Assert.AreEqual(originalTriangle.c_, copy.c_, "Конструктор копіювання не копіює дані");

        }
        [TestMethod]
        public void TTriangle_CannotBeCreated_WithNegativeOrZeroSides()
        {

            double a = -2;
            double b = 2;
            double c = 3;
            Assert.ThrowsException<Exception>(() => new TTriangle(a, b, c), "Сторони трикутника мають бути не від'ємними числами.");
        }

        [TestMethod]
        public void Checking_Parameters_Get()
        {
            double a = 5;
            double b = 6;
            double c = 7;
            TTriangle triangle = new TTriangle(a, b, c);

            double actualA = triangle.a_;
            double actualB = triangle.b_;
            double actualC = triangle.c_;

            Assert.AreEqual(a, actualA, "Get a_ повинен повертати правильне значення");
            Assert.AreEqual(b, actualB, "Get b_ повинен повертати правильне значення");
            Assert.AreEqual(c, actualC, "Get c_ повинен повертати правильне значення");

        }
        [TestMethod]
        public void Checking_Parameters_Set()
        {
            double a = 5;
            double b = 6;
            double c = 7;
            TTriangle triangle = new TTriangle(a, b, c);

            triangle.a_ = 6;
            triangle.b_ = 7;
            triangle.c_ = 8;

            Assert.AreEqual(6, triangle.a_, "Set a_ повинен повертати правильне значення");
            Assert.AreEqual(7, triangle.b_, "Set b_ повинен повертати правильне значення");
            Assert.AreEqual(8, triangle.c_, "Set c_ повинен повертати правильне значення");
        }

        [TestMethod]

        public void Checking_the_AreaTriangle_Method()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            double expected = 10.825317547305483;

            triangle.Area();

            Assert.AreEqual(expected, triangle.Area(), "Метод AreaTriangle повинен повернути правильне значення площі");

        }
        [TestMethod]
        public void Checking_the_Perimeter_Method()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            double expected = 15;

            triangle.Perimeter();

            Assert.AreEqual(expected, triangle.Perimeter(), "Метод Perimeter повинен повернути правильне значення площі");
        }
        [TestMethod]
        public void Checking_the_Comparison_MethodTrue()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            TTriangle triangle1 = new TTriangle(5, 5, 5);


            bool expected = triangle.Comparison(triangle1);

            Assert.IsTrue(expected, "Метод Comparison повинен виводити true");

        }

        [TestMethod]
        public void Checking_the_Comparison_MethodFalse()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            TTriangle triangle1 = new TTriangle(5, 5, 6);


            bool expected = triangle.Comparison(triangle1);

            Assert.IsFalse(expected, "Метод Comparison повинен виводити false");

        }
        [TestMethod]
        public void Overloading_the_SideByNumber_Operator()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            double multiplier = 5;
            TTriangle expectedTriangle = new TTriangle(25, 25, 25);

            TTriangle scaledTriangle = triangle * multiplier;

            Assert.AreEqual(expectedTriangle.a_, scaledTriangle.a_, "Cторона а має бути правильною після множиння");
            Assert.AreEqual(expectedTriangle.b_, scaledTriangle.b_, "Cторона b має бути правильною після множиння");
            Assert.AreEqual(expectedTriangle.c_, scaledTriangle.c_, "Cторона c має бути правильною після множиння");

        }
        [TestMethod]
        public void Overloading_the_NumberBySide_Operator()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            double multiplier = 5;
            TTriangle expectedTriangle = new TTriangle(25, 25, 25);

            TTriangle scaledTriangle = multiplier * triangle;

            Assert.AreEqual(expectedTriangle.a_, scaledTriangle.a_, "Cторона а має бути правильною після множиння");
            Assert.AreEqual(expectedTriangle.b_, scaledTriangle.b_, "Cторона b має бути правильною після множиння");
            Assert.AreEqual(expectedTriangle.c_, scaledTriangle.c_, "Cторона c має бути правильною після множиння");

        }





    }
}