using lab1_2_3;
using TestProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TriangleTests
{
    [TestClass]
    public class TTrianglePrizmTests
    {
        [TestMethod]
        public void Constructor_Without_Prism_Parameters()
        {
            TTrianglePrizm prizm = new TTrianglePrizm();

            Assert.AreEqual(0, prizm.a_, "�������� � �� ���������� 0");
            Assert.AreEqual(0, prizm.b_, "�������� b �� ���������� 0");
            Assert.AreEqual(0, prizm.c_, "�������� c �� ���������� 0");
            Assert.AreEqual(0, prizm.h_, "�������� � �� ���������� 0");
        }
        [TestMethod]
        public void Constructor_Prizm_Parameter_Options()
        {
            double a = 4;
            double b = 4;
            double c = 4;
            double h = 8;
            TTrianglePrizm prizm = new TTrianglePrizm(a, b, c, h);


            Assert.AreEqual(a, prizm.a_, "������� � �� ������� ����� ���������");
            Assert.AreEqual(b, prizm.b_, "������� b �� ������� ����� ���������");
            Assert.AreEqual(c, prizm.c_, "������� c �� ������� ����� ���������");
            Assert.AreEqual(h, prizm.h_, "������ ������ �� ������� ����� ���������");
        }
        [TestMethod]
        public void Copy_ConstructorPrizm()
        {
            TTrianglePrizm originalPrizm = new TTrianglePrizm(5, 6, 7, 6);

            TTrianglePrizm copy = new TTrianglePrizm(originalPrizm);

            Assert.AreEqual(originalPrizm.a_, copy.a_, 0.0001, "����������� ��������� �� ����� ��� ��� �");
            Assert.AreEqual(originalPrizm.b_, copy.b_, 0.0001, "����������� ��������� �� ����� ��� ��� b");
            Assert.AreEqual(originalPrizm.c_, copy.c_, 0.0001, "����������� ��������� �� ����� ��� ��� c");
            Assert.AreEqual(originalPrizm.h_, copy.h_, 0.0001, "����������� ��������� �� ����� ���  ��� ������� ������");
        }


        [TestMethod]
        public void Checking_ParametersPrizm_Get()
        {

            double a = 3, b = 4, c = 5, h = 5;
            TTrianglePrizm prizm = new TTrianglePrizm(a, b, c, h);

            double expectedH = prizm.h_;

            Assert.AreEqual(h, expectedH, "Get H ������� ��������� ��������� ��������");


        }
        [TestMethod]
        public void Checking_ParametersPrizm_Set()
        {
            double a = 3, b = 4, c = 5, H = 5, newH = 7;
            TTrianglePrizm prizm = new TTrianglePrizm(a, b, c, H);

            prizm.h_ = newH;

            Assert.AreEqual(newH, prizm.h_, "Set H ������� ��������� ��������� ��������");
        }

        [TestMethod]
        public void Height_IsGreater_Than_Zero()
        {
            double a = 3, b = 4, c = 5, h = -5;

            var exception = Assert.ThrowsException<Exception>(() => new TTrianglePrizm(a, b, c, h));
            Assert.AreEqual("������ �� ���� ������� ������.", exception.Message);
        }


        [TestMethod]
        public void Checking_the_PrizmVolume_Method()
        {

            TTrianglePrizm prizm = new TTrianglePrizm(5, 5, 5, 11);
            double expected = 119.07849302036031;

            prizm.PrizmVolume();

            Assert.AreEqual(expected, prizm.PrizmVolume(), "����� PrizmVolume ������� ��������� ��������� �������� �����");

        }
        [TestMethod]
        public void Checking_the_Area_Method()
        {
            TTrianglePrizm prizm = new TTrianglePrizm(5, 7, 6, 11);
            double expected = 227.39387691339815;

            prizm.Area();
            Assert.AreEqual(expected, prizm.Area());
        }
        [TestMethod]
        public void Checking_the_Comparison_MethodTrue()
        {
            TTrianglePrizm prizm1 = new TTrianglePrizm(5, 5, 5, 11);
            TTrianglePrizm prizm2 = new TTrianglePrizm(5, 5, 5, 11);


            bool expected = prizm1.Comparison(prizm2);

            Assert.IsTrue(expected, "����� Comparison ������� �������� true");

        }
        [TestMethod]
        public void Checking_the_Comparison_MethodFalse()
        {
            TTrianglePrizm prizm1 = new TTrianglePrizm(5, 5, 6, 11);
            TTrianglePrizm prizm2 = new TTrianglePrizm(5, 5, 5, 19);


            bool expected = prizm1.Comparison(prizm2);

            Assert.IsFalse(expected, "����� Comparison ������� �������� false");
        }

        [TestMethod]
        public void Multiplication_Of_NumberByA_Prism()
        {
            TTrianglePrizm prizm = new TTrianglePrizm(5, 5, 6, 11);
            double multiplier = 5;
            TTrianglePrizm expectedTriangle = new TTrianglePrizm(25, 25, 30, 55);

            TTrianglePrizm scaledTriangle = prizm * multiplier;

            Assert.AreEqual(expectedTriangle.a_, scaledTriangle.a_, "C������ � �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.b_, scaledTriangle.b_, "C������ b �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.c_, scaledTriangle.c_, "C������ c �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.h_, scaledTriangle.h_, "������ �� ���� ���������� ���� ��������");
        }
        [TestMethod]
        public void Multiplication_Of_PrismByA_Number()
        {
            TTrianglePrizm prizm = new TTrianglePrizm(5, 5, 6, 11);
            double multiplier = 5;
            TTrianglePrizm expectedTriangle = new TTrianglePrizm(25, 25, 30, 55);

            TTrianglePrizm scaledTriangle = multiplier * prizm;

            Assert.AreEqual(expectedTriangle.a_, scaledTriangle.a_, "C������ � �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.b_, scaledTriangle.b_, "C������ b �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.c_, scaledTriangle.c_, "C������ c �� ���� ���������� ���� ��������");
            Assert.AreEqual(expectedTriangle.h_, scaledTriangle.h_, "������ �� ���� ���������� ���� ��������");
        }
    }


}