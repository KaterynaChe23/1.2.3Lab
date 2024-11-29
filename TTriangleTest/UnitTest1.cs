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
        public void �onstructor_ParametersSidesToZero()
        {

            TTriangle triangle = new TTriangle();

            Assert.AreEqual(0, triangle.a_, "�������� � �� ���������� 0");
            Assert.AreEqual(0, triangle.b_, "�������� b �� ���������� 0");
            Assert.AreEqual(0, triangle.c_, "�������� c �� ���������� 0");
        }
        [TestMethod]
        public void Constructor_With_Parameter_Options()
        {
            TTriangle triangle1 = new TTriangle(5, 6, 7);

            Assert.AreEqual(5, triangle1.a_, "������� � �� ������� ����� ���������");
            Assert.AreEqual(6, triangle1.b_, "������� b �� ������� ����� ���������");
            Assert.AreEqual(7, triangle1.c_, "������� c �� ������� ����� ���������");
        }

        [TestMethod]
        public void TTriangle_CannotBeCreated_WithInvalidSides()
        {

            double a = 1;
            double b = 2;
            double c = 3;


            var exception = Assert.ThrowsException<Exception>(() => new TTriangle(a, b, c));
            Assert.AreEqual("����� ������� �� ������ �������� ���������.", exception.Message);
        }
        [TestMethod]
        public void Copy_Constructor()
        {
            TTriangle originalTriangle = new TTriangle(5, 6, 7);

            TTriangle copy = new TTriangle(originalTriangle);

            Assert.AreEqual(originalTriangle.a_, copy.a_, "����������� ��������� �� ����� ���");
            Assert.AreEqual(originalTriangle.b_, copy.b_, "����������� ��������� �� ����� ���");
            Assert.AreEqual(originalTriangle.c_, copy.c_, "����������� ��������� �� ����� ���");

        }
        [TestMethod]
        public void TTriangle_CannotBeCreated_WithNegativeOrZeroSides()
        {

            double a = -2;
            double b = 2;
            double c = 3;
            Assert.ThrowsException<Exception>(() => new TTriangle(a, b, c), "������� ���������� ����� ���� �� ��'������ �������.");
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

            Assert.AreEqual(a, actualA, "Get a_ ������� ��������� ��������� ��������");
            Assert.AreEqual(b, actualB, "Get b_ ������� ��������� ��������� ��������");
            Assert.AreEqual(c, actualC, "Get c_ ������� ��������� ��������� ��������");

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

            Assert.AreEqual(6, triangle.a_, "Set a_ ������� ��������� ��������� ��������");
            Assert.AreEqual(7, triangle.b_, "Set b_ ������� ��������� ��������� ��������");
            Assert.AreEqual(8, triangle.c_, "Set c_ ������� ��������� ��������� ��������");
        }

        [TestMethod]

        public void Checking_the_AreaTriangle_Method()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            double expected = 10.825317547305483;

            triangle.Area();

            Assert.AreEqual(expected, triangle.Area(), "����� AreaTriangle ������� ��������� ��������� �������� �����");

        }
        [TestMethod]
        public void Checking_the_Perimeter_Method()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            double expected = 15;

            triangle.Perimeter();

            Assert.AreEqual(expected, triangle.Perimeter(), "����� Perimeter ������� ��������� ��������� �������� �����");
        }
        [TestMethod]
        public void Checking_the_Comparison_MethodTrue()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            TTriangle triangle1 = new TTriangle(5, 5, 5);


            bool expected = triangle.Comparison(triangle1);

            Assert.IsTrue(expected, "����� Comparison ������� �������� true");

        }

        [TestMethod]
        public void Checking_the_Comparison_MethodFalse()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            TTriangle triangle1 = new TTriangle(5, 5, 6);


            bool expected = triangle.Comparison(triangle1);

            Assert.IsFalse(expected, "����� Comparison ������� �������� false");

        }
        [TestMethod]
        public void Overloading_the_SideByNumber_Operator()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            double multiplier = 5;
            TTriangle expectedTriangle = new TTriangle(25, 25, 25);

            TTriangle scaledTriangle = triangle * multiplier;

            Assert.AreEqual(expectedTriangle.a_, scaledTriangle.a_, "C������ � �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.b_, scaledTriangle.b_, "C������ b �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.c_, scaledTriangle.c_, "C������ c �� ���� ���������� ���� ��������");

        }
        [TestMethod]
        public void Overloading_the_NumberBySide_Operator()
        {
            TTriangle triangle = new TTriangle(5, 5, 5);
            double multiplier = 5;
            TTriangle expectedTriangle = new TTriangle(25, 25, 25);

            TTriangle scaledTriangle = multiplier * triangle;

            Assert.AreEqual(expectedTriangle.a_, scaledTriangle.a_, "C������ � �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.b_, scaledTriangle.b_, "C������ b �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.c_, scaledTriangle.c_, "C������ c �� ���� ���������� ���� ��������");

        }





    }
}