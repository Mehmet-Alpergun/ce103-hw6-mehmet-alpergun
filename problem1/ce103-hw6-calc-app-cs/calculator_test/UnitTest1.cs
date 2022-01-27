using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LesGraphingCalc;

namespace ce103_hw6_calc_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        public void CalculateTest1()
        {
            var expected = RPN.Calculate("50 + 20");
            var actual = 70;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest2()
        {
            var expected = RPN.Calculate("55 - 25");
            var actual = 30;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CalculateTest3()
        {
            var expected = RPN.Calculate("sqrt(16");
            var actual = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest4()
        {
            var expected = RPN.Calculate("ln(e^5");
            var actual = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest5()
        {
            var expected = RPN.Calculate("lg(1000");
            var actual = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest6()
        {
            var expected = RPN.Calculate(" %10");
            var actual = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest7()
        {
            var expected = RPN.Calculate(" !3");
            var actual = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest8()
        {
            var expected = RPN.Calculate(" 8 * 7");
            var actual = 56;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest9()
        {
            var expected = RPN.Calculate(" 20 / 4");
            var actual = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest10()
        {
            var expected = RPN.Calculate(" 2^5");
            var actual = 32;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest11()
        {
            var expected = RPN.Calculate(" 2^6");
            var actual = 64;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest12()
        {
            var expected = RPN.Calculate(" 0^y");
            var actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest13()
        {
            var expected = RPN.Calculate("(1/100");
            var actual = 0.01;
            Assert.AreEqual(expected, actual);
        }
    }
}
