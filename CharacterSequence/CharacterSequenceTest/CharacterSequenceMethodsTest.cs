using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSequence;

namespace CharacterSequenceTest
{
    [TestClass]
    public class CharacterSequenceMethodsTest
    {
        [TestMethod]
        public void GetMaxNumberOfNonidenticalConsecutiveCharacters_OneSymbol_ReturnCorrectAnswer()
        {
            int expected = 1;
            string oneSymbolString = "a";
            int actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(oneSymbolString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfNonidenticalConsecutiveCharacters_TwoSameSymbols_ReturnCorrectAnswer()
        {
            int expected = 1;
            string twoSameSymbolsString = "aa";
            int actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(twoSameSymbolsString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfNonidenticalConsecutiveCharacters_TwoDifferentSymbols_ReturnCorrectAnswer()
        {
            int expected = 2;
            string twoDifferentSymbolsString = "ab";//case of two different symbol
            int actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(twoDifferentSymbolsString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abb", 2)]
        [DataRow("aab", 2)]
        [DataRow("aabb", 2)]
        [DataRow("abbccd", 2)]
        [DataRow("aqbbccd", 3)]
        [DataRow("abbqccd", 3)]
        [DataRow("aqbbccqd", 3)]
        public void GetMaxNumberOfNonidenticalConsecutiveCharacters_DifferentCasesOfSymbolsSequences_ReturnCorrectAnswer(string testString, int expected)
        {
            int actual = Program.GetMaxNumberOfNonidenticalConsecutiveCharacters(testString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForNumbers_StringWithoutNumbers_ReturnCorrectAnswer()
        {
            int expected = 0;
            string stringWithoutNumbers = "abcz";
            Program.SymbolDetermination isNumber = Program.IsNumber;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(stringWithoutNumbers, isNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForNumbers_LeftBoundaryCondition_OutOfRange_ReturnCorrectAnswer()
        {
            int expected = 0;
            string leftBoundaryCondition = "///";
            Program.SymbolDetermination isNumber = Program.IsNumber;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(leftBoundaryCondition, isNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForNumbers_RightBoundaryCondition_OutOfRange_ReturnCorrectAnswer()
        {
            int expected = 0;
            string rightBoundaryCondition = ":::";
            Program.SymbolDetermination isNumber = Program.IsNumber;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(rightBoundaryCondition, isNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForNumbers_LeftBoundaryCondition_InRange_ReturnCorrectAnswer()
        {
            int expected = 3;
            string leftBoundaryCondition = "000";
            Program.SymbolDetermination isNumber = Program.IsNumber;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(leftBoundaryCondition, isNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForNumbers_RightBoundaryCondition_InRange_ReturnCorrectAnswer()
        {
            int expected = 3;
            string rightBoundaryCondition = "999";
            Program.SymbolDetermination isNumber = Program.IsNumber;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(rightBoundaryCondition, isNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("1", 1)]
        [DataRow("a12b", 1)]
        [DataRow("11", 2)]
        [DataRow("11a", 2)]
        [DataRow("a11", 2)]
        [DataRow("a112", 2)]
        [DataRow("11a22b33", 2)]
        [DataRow("1", 1)]
        [DataRow("111a2233", 3)]
        [DataRow("11a22233", 3)]
        [DataRow("11a22333", 3)]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForNumbers_DifferentCasesOfIdenticalConsecutiveNumberSequences_ReturnCorrectAnswer(string testString, int expected)
        {
            Program.SymbolDetermination isNumber = Program.IsNumber;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(testString, isNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForLatinSymbols_StringWithoutLatinSymbols_ReturnCorrectAnswer()
        {
            int expected = 0;
            string stringWithoutLatinSymbols = "1233";
            Program.SymbolDetermination isLatin = Program.IsLatin;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(stringWithoutLatinSymbols, isLatin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForLatinSymbols_LeftBoundaryCondition_OutOfRange_ReturnCorrectAnswer()
        {
            int expected = 0;
            string leftBoundaryCondition = "```";
            Program.SymbolDetermination isLatin = Program.IsLatin;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(leftBoundaryCondition, isLatin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForLatinSymbols_RightBoundaryCondition_OutOfRange_ReturnCorrectAnswer()
        {
            int expected = 0;
            string rightBoundaryCondition = "{{{";
            Program.SymbolDetermination isLatin = Program.IsLatin;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(rightBoundaryCondition, isLatin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForLatinSymbols_LeftBoundaryCondition_InRange_ReturnCorrectAnswer()
        {
            int expected = 3;
            string leftBoundaryCondition = "aaa";
            Program.SymbolDetermination isLatin = Program.IsLatin;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(leftBoundaryCondition, isLatin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForLatinSymbols_RightBoundaryCondition_InRange_ReturnCorrectAnswer()
        {
            int expected = 3;
            string rightBoundaryCondition = "zzz";
            Program.SymbolDetermination isLatin = Program.IsLatin;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(rightBoundaryCondition, isLatin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("c", 1)]
        [DataRow("bc", 1)]
        [DataRow("a12b", 1)]
        [DataRow("cc", 2)]
        [DataRow("cca", 2)]
        [DataRow("1bb", 2)]
        [DataRow("add2", 2)]
        [DataRow("dd2aa3cc", 2)]
        [DataRow("vvv2ddff", 3)]
        [DataRow("vv3gggww", 3)]
        [DataRow("vv3gg3www", 3)]
        public void GetMaxNumberOfIdenticalConsecutiveSymbols_ForLatinSymbols_DifferentCasesOfIdenticalConsecutiveLatinSymbolSequences_ReturnCorrectAnswer(string testString, int expected)
        {
            Program.SymbolDetermination isLatin = Program.IsLatin;
            int actual = Program.GetMaxNumberOfIdenticalConsecutiveSymbols(testString, isLatin);
            Assert.AreEqual(expected, actual);
        }
    }
}
