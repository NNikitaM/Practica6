using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practica6;
using Zadanie2;
//using Zadanie3;
//using Zadanie4;
//using Zadanie5;
//using Zadanie6;

namespace Example1.Tests
{
    [TestClass]
    public class Example1Tests
    {
        //Task1
        [TestMethod]
        public void Zadanie1_1()
        {
            int a = 23;
            int b = 423;
            int c = 12;
            int exp = 3;
            int act = Practica6.MainWindow.f(a);
            int act1 = Practica6.MainWindow.f(b);
            int act2 = Practica6.MainWindow.f(c);
            int act3 = act + act1 - act2;
            Assert.AreEqual(exp, act3);
        }

        [TestMethod]
        public void Zadanie1_2()
        {
            int a = 2;
            int b = 4;
            int c = 1;
            int exp = 0;
            int act = Practica6.MainWindow.f(a);
            int act1 = Practica6.MainWindow.f(b);
            int act2 = Practica6.MainWindow.f(c);
            int act3 = act + act1 - act2;
            Assert.AreEqual(exp, act3);
        }

        [TestMethod]
        public void Zadanie1_3()
        {
            int a = -23;
            int b = -3;
            int c = -2;
            int exp = -2;
            int act = Practica6.MainWindow.f(a);
            int act1 = Practica6.MainWindow.f(b);
            int act2 = Practica6.MainWindow.f(c);
            int act3 = act + act1 - act2;
            Assert.AreEqual(exp, act3);
        }

        //Task2
        [TestMethod]
        public void Zadanie2_1()
        {
            int a = 6;
            int b = 13;
            int c = 21;
            double exp = -0.52;
            double act = Zadanie2.MainWindow.f1(a);
            double act1 = Zadanie2.MainWindow.f1(b);
            double act2 = Zadanie2.MainWindow.f1(c);
            double act3 = act + act1 - act2;
            Assert.AreEqual(exp, act3, 0.01);
        }

        [TestMethod]
        public void Zadanie2_2()
        {
            int a = -6;
            int b = 13;
            int c = 21;
            double exp = -8.97;
            double act = Zadanie2.MainWindow.f1(a);
            double act1 = Zadanie2.MainWindow.f1(b);
            double act2 = Zadanie2.MainWindow.f1(c);
            double act3 = act + act1 - act2;
            Assert.AreEqual(exp, act3, 0.01);
        }

        [TestMethod]
        public void Zadanie2_3()
        {
            int a = -6;
            int b = -13;
            int c = -21;
            double exp = 0;
            double act = Zadanie2.MainWindow.f1(a);
            double act1 = Zadanie2.MainWindow.f1(b);
            double act2 = Zadanie2.MainWindow.f1(c);
            double act3 = act + act1 - act2;
            Assert.AreEqual(exp, act3);
        }

        //Task3
        [TestMethod]
        public void Zadanie3_1()
        {
            int a = 6;
            int b = 13;
            double exp = 4.36;
            double act = Convert.ToDouble(Zadanie3.MainWindow.Gipotenuza(a, b));
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie3_2()
        {
            int a = -6;
            int b = 13;
            double exp = 2.65;
            double act = Convert.ToDouble(Zadanie3.MainWindow.Gipotenuza(a, b));
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie3_3()
        {
            int a = 0;
            int b = 13;
            double exp = 3.61;
            double act = Convert.ToDouble(Zadanie3.MainWindow.Gipotenuza(a, b));
            Assert.AreEqual(exp, act);
        }

        //Task4
        [TestMethod]
        public void Zadanie4_1()
        {
            int a = 5;
            int b = 10;
            int h = 2;
            double x = -1;
            double exp = -4;
            double act = Zadanie4.MainWindow.Tas(a, b, h, x);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie4_2()
        {
            int a = 5;
            int b = 10;
            int h = 2;
            double x = 0.5;
            double exp = 0.25;
            double act = Zadanie4.MainWindow.Tas(a, b, h, x);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie4_3()
        {
            int a = 5;
            int b = 10;
            int h = 2;
            double x = 3;
            double exp = 2;
            double act = Zadanie4.MainWindow.Tas(a, b, h, x);
            Assert.AreEqual(exp, act);
        }

        //Task5
        [TestMethod]
        public void Zadanie5_1()
        {
            double a = 5;
            double b = 6;
            double c = 7;
            double d = 8;
            double e = 9;
            double g = 10;
            double f = 11;
            double exp = 68.49;
            double act = Zadanie5.MainWindow.Treu(a, b, f);
            double act1 = Zadanie5.MainWindow.Treu(g, c, f);
            double act2 = Zadanie5.MainWindow.Treu(e, d, g);
            double act3 = act + act1 + act2;
            Assert.AreEqual(exp, act3, 0.01);
        }
        [TestMethod]
        public void Zadanie5_2()
        {
            double a = 0;
            double b = 9;
            double c = 5;
            double d = 8;
            double e = 6;
            double g = 4;
            double f = 7;
            double exp = 21.42;
            double act = Zadanie5.MainWindow.Treu(a, b, f);
            double act1 = Zadanie5.MainWindow.Treu(g, c, f);
            double act2 = Zadanie5.MainWindow.Treu(e, d, g);
            double act3 = act + act1 + act2;
            Assert.AreEqual(exp, act3, 0.01);
        }
        [TestMethod]
        public void Zadanie5_3()
        {
            double a = 0;
            double b = 8;
            double c = 5;
            double d = 0;
            double e = 6;
            double g = -6;
            double f = -8;
            double exp = 14.98;
            double act = Zadanie5.MainWindow.Treu(a, b, f);
            double act1 = Zadanie5.MainWindow.Treu(g, c, f);
            double act2 = Zadanie5.MainWindow.Treu(e, d, g);
            double act3 = act + act1 + act2;
            Assert.AreEqual(exp, act3, 0.01);
        }

        //Task6
        [TestMethod]
        public void Zadanie6_1()
        {
            int N1 = 1;
            int N2 = 2;
            int N3 = 3;
            int N4 = 4;
            int N5 = 5;
            double[] exp = { 1, 1, 2, 3, 5};
            double[] act = {Zadanie6.MainWindow.Fib(N1), Zadanie6.MainWindow.Fib(N2), Zadanie6.MainWindow.Fib(N3), Zadanie6.MainWindow.Fib(N4), Zadanie6.MainWindow.Fib(N5) };
            CollectionAssert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie6_2()
        {
            int N1 = -1;
            int N2 = -2;
            int N3 = -3;
            int N4 = -4;
            int N5 = -5;
            double[] exp = { 0, 0, 0, 0, 0 };
            double[] act = { Zadanie6.MainWindow.Fib(N1), Zadanie6.MainWindow.Fib(N2), Zadanie6.MainWindow.Fib(N3), Zadanie6.MainWindow.Fib(N4), Zadanie6.MainWindow.Fib(N5) };
            CollectionAssert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie6_3()
        {
            int N1 = 1;
            int N2 = 0;
            int N3 = -3;
            int N4 = 4;
            int N5 = 5;
            double[] exp = { 1, 0, 0, 3, 5 };
            double[] act = { Zadanie6.MainWindow.Fib(N1), Zadanie6.MainWindow.Fib(N2), Zadanie6.MainWindow.Fib(N3), Zadanie6.MainWindow.Fib(N4), Zadanie6.MainWindow.Fib(N5) };
            CollectionAssert.AreEqual(exp, act);
        }
    }
}
