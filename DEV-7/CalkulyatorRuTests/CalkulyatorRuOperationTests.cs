using NUnit.Framework;

namespace CalkulyatorRuTests
{
    public class CalkulyatorRuOperationTests
    {
        [TestCase("2+8=", "10")]
        [TestCase("13+2=", "15")]
        [TestCase("4+5000=", "5004")]
        [TestCase("79+27=", "106")]
        public void AdditionIntegerNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("3.5+8=", "11.5")]
        [TestCase("9.6+2.8=", "12.4")]
        [TestCase("68.356+42.921=", "111.277")]
        public void AdditionFractionalNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("3(-)+2=", "-1")]
        [TestCase("4(-)+2(-)=", "-6")]
        [TestCase("5(-)+7=", "2")]
        [TestCase("8.56(-)+3.59=", "-4.97")]
        public void AdditionNegativelNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }


        [TestCase("10-8=", "2")]
        [TestCase("9-12=", "-3")]
        [TestCase("2356-2000=", "356")]
        public void SubtractionnIntegerNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("12.8-5=", "7.8")]
        [TestCase("8.345-10.567=", "-2.222")]
        public void SubtractionnFractionalNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("3(-)-2=", "-5")]
        [TestCase("4(-)-2(-)=", "-2")]
        [TestCase("5-7(-)=", "12")]
        [TestCase("8.56(-)-3.59=", "-12.15")]
        public void SubtractionnNegativeNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("5*0=", "0")]
        [TestCase("0*2=", "0")]
        [TestCase("2*3=", "6")]
        [TestCase("37*4=", "148")]
        [TestCase("29*13=", "377")]
        public void MultiplicationIntegerNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("5.2*0=", "0")]
        [TestCase("2.3*3=", "6.9")]
        [TestCase("2.4*3=", "7.2")]
        [TestCase("25.72*4.28=", "110.0816")]
        public void MultiplicationFractionalNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("5(-)*0=", "0")]
        [TestCase("2.3(-)*3=", "-6.9")]
        [TestCase("2(-)*3=", "-6")]
        [TestCase("8(-)*3(-)=", "24")]
        public void MultiplicationNegativeNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("0/1=", "0")]
        [TestCase("2/1=", "2")]
        [TestCase("6/12=", "0.5")]
        [TestCase("347/1256=", "0.2763")]
        public void DivisionIntegerNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("0/1.5=", "0")]
        [TestCase("3.67/1=", "3.67")]
        [TestCase("4.28/0.25=", "17.12")]
        [TestCase("124.45/26.34=", "4.7248")]
        public void DivisionFractionalNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("0/1(-)=", "0")]
        [TestCase("3/1(-)=", "-3")]
        [TestCase("4(-)/2=", "-2")]
        [TestCase("4(-)/2(-)=", "2")]
        [TestCase("14.4(-)/2.4=", "-6")]
        public void DivisionNegativeNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("0√=", "0")]
        [TestCase("4√=", "2")]
        [TestCase("256√=", "16")]
        [TestCase("13√=", "3.605551275464")]
        [TestCase("1256√=", "35.440090293339")]
        public void SquareRootIntegerNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1.44√=", "1.2")]
        [TestCase("272.25√=", "16.5")]
        public void SquareRootFractialNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1(-)√=", "NaN")]
        [TestCase("2.5(-)√=", "NaN")]
        public void SquareRootNegativeNumbersTest_DisplaysNaNMessage(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("2^0=", "1")]
        [TestCase("0^2=", "0")]
        [TestCase("4^2=", "16")]
        [TestCase("3^10=", "59049")]
        public void ExponentiationIntegerNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("2.5^0=", "1")]
        [TestCase("1^2.34=", "1")]
        [TestCase("4.5^2=", "20.25")]
        [TestCase("3.6^1.7=", "8.825")]
        public void ExponentiationFractialNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1(-)^2=", "1")]
        [TestCase("1(-)^3=", "-1")]
        [TestCase("2^2(-)=", "0.25")]
        [TestCase("2.5^1.5(-)=", "0.253")]
        public void ExponentiationNegativeNumbersTest_DisplaysCorrectAnswer(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1(-)^2.5=", "NaN")]
        [TestCase("2(-)^2.19(-)=", "NaN")]
        [TestCase("2.5(-)^1.19=", "NaN")]
        public void ExponentiationNegativeNumbersunderFractialPowerTest_DisplaysNaNMessage(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1111DELDELDEL", "1")]
        [TestCase("11(-)DEL", "-1")]
        [TestCase("11.1111DELDEL", "11.11")]
        [TestCase("11.111DELDELDEL", "11")]
        [TestCase("11.111DELDELDELDEL", "1")]
        public void DelateNumberOperationTest_DisplaysCorrectValue(string buttonSequence, string expected)
        {
            string actual = TestInvoker.GetResult(buttonSequence);
            Assert.AreEqual(expected, actual);
        }
    }
}