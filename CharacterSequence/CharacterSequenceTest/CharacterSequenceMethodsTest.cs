using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSequence;

namespace CharacterSequenceTest
{
    [TestClass]
    public class CharacterSequenceMethodsTest
    {
        [TestMethod]
        public void GetMaxNumberOfNonidenticalConsecutiveCharacters_Test()//test for method GetMaxNumberOfNonidenticalConsecutiveCharacters
        {   
            int expected = 1;

            string testString = "a";//case of one symbol
            int actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "aa";//case of two same symbol
            actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);

            expected = 2;

            testString = "ab";//case of two different symbol
            actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "abb";//case of sequence of nonidentical consecutive characters in the beggining of string
            actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "aab";//case of sequence of nonidentical consecutive characters in the end of string
            actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "aabb";//case of sequence of nonidentical consecutive characters in the middle of string
            actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "abbccd";//case of three sequences of nonidentical consecutive characters with same length
            actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);

            expected = 3;

            testString = "aqbbccd";//case of three sequences of nonidentical consecutive characters, where the longest one located in the beggining of string
            actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "abbqccd";//case of three sequences of nonidentical consecutive characters, where the longest one located in the middle of string
            actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "aqbbccqd";//case of three sequences of nonidentical consecutive characters, where the longest one located in the end of string
            actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveNumbers_Test()
        {
            int expected = 0;

            string testString = "abcz";//case of string without numbers
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "b";//case of string with one not numeric symbol 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "///";//case of left boundary condition (out of range)
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = ":::";//case of right boundary condition (out of range)
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            expected = 1;

            testString = "1";//case for string with one numeric symbol 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "12";//case for string with two different numeric symbol s
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "a12b";//case for string with numeric and not numeric symbol 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            expected = 2;

            testString = "11";//case for string with two same numeric symbols 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "11a";//case for string with two same numeric symbols in the begininng of string  
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "a11";//case for string with two same numeric symbols in the end of string  
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "a112";//case for string with two same numeric symbols in the middle of string  
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "11a22b33";//case of three sequences of nidentical consecutive numeric characters with same length 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            expected = 3;

            testString = "111a2233";//case of three sequences of nidentical consecutive numeric characters, where the longest placed in the beginning if string
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "11a22233";//case of three sequences of identical consecutive numeric characters, where the longest placed in the middle if string
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "11a22333";//case of three sequences of identical consecutive numeric characters, where the longest placed in the end if string
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "000";//case of left boundary condition (in range)
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);

            testString = "999";//case of right boundary condition (in range)
            actual = Program.GetMaxNumberOfIdenticalConsecutiveNumbers(testString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveLatinCharacters_Test()
        {
            int expected = 0;

            string testString = "1233";//case of string without latin symbols
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "1";//case of string with one not latin symbol 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "```";//case of left boundary condition (out of range)
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "{{{";//case of right boundary condition (out of range)
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            expected = 1;

            testString = "c";//case for string with one latin symbol 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "bc";//case for string with two different latin symbols
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "a12b";//case for string with latin and not latin symbols 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            expected = 2;

            testString = "cc";//case for string with two same latin symbols 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "cca";//case for string with two same latin symbols in the begininng of string  
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "1bb";//case for string with two same latin symbols in the end of string  
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "add2";//case for string with two same latin symbols in the middle of string  
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "dd2aa3cc";//case of three sequences of identical consecutive latin symbols with same length 
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            expected = 3;

            testString = "vvv2ddff";//case of three sequences of identical consecutive latin symbols, where the longest placed in the beginning if string
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "vv3gggww";//case of three sequences of identical consecutive latin symbols, where the longest placed in the middle if string
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "vv3gg3www";//case of three sequences of identical consecutive latin symbols, where the longest placed in the end if string
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "aaa";//case of left boundary condition (in range)
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);

            testString = "zzz";//case of right boundary condition (in range)
            actual = Program.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(testString);
            Assert.AreEqual(expected, actual);
        }
    }
}
