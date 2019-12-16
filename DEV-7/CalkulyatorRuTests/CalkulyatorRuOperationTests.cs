using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Chrome;
using DEV_7;

namespace CalkulyatorRuTests
{
    public class CalkulyatorRuOperationTests
    {
        [TestCase("2+8=", "10")]
        [TestCase("13+2=", "15")]
        [TestCase("4+5000=", "5004")]
        [TestCase("79+27=", "106")]
        public void AdditionIntegerNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("3.5+8=", "11.5")]
        [TestCase("9.6+2.8=", "12.4")]
        [TestCase("68.356+42.921=", "111.277")]
        public void AdditionFractionalNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("3(-)+2=", "-1")]
        [TestCase("4(-)+2(-)=", "-6")]
        [TestCase("5(-)+7=", "2")]
        [TestCase("8.56(-)+3.59=", "-4.97")]
        public void AdditionNegativelNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }


        [TestCase("10-8=", "2")]
        [TestCase("9-12=", "-3")]
        [TestCase("2356-2000=", "356")]
        public void SubtractionnIntegerNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("12.8-5=", "7.8")]
        [TestCase("8.345-10.567=", "-2.222")]
        public void SubtractionnFractionalNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("3(-)-2=", "-5")]
        [TestCase("4(-)-2(-)=", "-2")]
        [TestCase("5-7(-)=", "12")]
        [TestCase("8.56(-)-3.59=", "-12.15")]
        public void SubtractionnNegativeNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("5*0=", "0")]
        [TestCase("0*2=", "0")]
        [TestCase("2*3=", "6")]
        [TestCase("37*4=", "148")]
        [TestCase("29*13=", "377")]
        public void MultiplicationIntegerNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("5.2*0=", "0")]
        [TestCase("2.3*3=", "6.9")]
        [TestCase("2.4*3=", "7.2")]
        [TestCase("25.72*4.28=", "110.0816")]
        public void MultiplicationFractionalNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("5(-)*0=", "0")]
        [TestCase("2.3(-)*3=", "-6.9")]
        [TestCase("2(-)*3=", "-6")]
        [TestCase("8(-)*3(-)=", "24")]
        public void MultiplicationNegativeNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("0/1=", "0")]
        [TestCase("2/1=", "2")]
        [TestCase("6/12=", "0.5")]
        [TestCase("347/1256=", "0.2763")]
        public void DivisionIntegerNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("0/1.5=", "0")]
        [TestCase("3.67/1=", "3.67")]
        [TestCase("4.28/0.25=", "17.12")]
        [TestCase("124.45/26.34=", "4.7248")]
        public void DivisionFractionalNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("0/1(-)=", "0")]
        [TestCase("3/1(-)=", "-3")]
        [TestCase("4(-)/2=", "-2")]
        [TestCase("4(-)/2(-)=", "2")]
        [TestCase("14.4(-)/2.4=", "-6")]
        public void DivisionNegativeNumbersTest_ReturnsCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("0/0=")]
        public void DivisionByZero(string buttonSequence)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            string expected = ""
        }
    }
}