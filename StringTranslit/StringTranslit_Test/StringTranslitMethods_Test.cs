using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringTranslit;

namespace StringTranslit_Test
{
    [TestClass]
    public class StringTranslitMethods_Test
    {
        [TestMethod]
        public void InputStringCheck_ZeroLengthString_ShouldThrowZeroLengthStringException()
        {
            string inputString = "";

            Assert.ThrowsException<ZeroLengthStringException>(() => Program.InputStringCheck(inputString));
        }

        [TestMethod]
        public void InputStringCheck_StringContainsRussianAndEnglishSymbols_ShouldThrowRussianAndEnglishSymbolsStringException()
        {
            string inputString = "abcгрп";

            Assert.ThrowsException<RussianAndEnglishSymbolsStringException>(() => Program.InputStringCheck(inputString));
        }

        [TestMethod]
        public void InputStringCheck_StringContainsInvalidSymbols_ShouldThrowInvalidSymbolStringException()
        {
            string inputString = " ?.,#*";

            Assert.ThrowsException<InvalidSymbolStringException>(() => Program.InputStringCheck(inputString));
        }

        [TestMethod]
        public void InputStringCheck_EnglishBoundaryConditionsPositive_ShouldReturnTrue()
        {
            string inputString = "az";

            bool actual = Program.InputStringCheck(inputString);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InputStringCheck_EnglishBoundaryConditionsNegative_ShouldThrowInvalidSymbolStringException()
        {
            string inputString = "`{";

            Assert.ThrowsException<InvalidSymbolStringException>(() => Program.InputStringCheck(inputString));
        }

        [TestMethod]
        public void InputStringCheck_RussianBoundaryConditionsPositive_ShoulReturnTrue()
        {
            string inputString = "аяё";

            bool actual = Program.InputStringCheck(inputString);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void InputStringCheck_RussianBoundaryConditionsNegative_ShouldThrowInvalidSymbolStringException()
        {
            char yo = 'ё';
            char leftBoundaryYO = --yo;
            yo = 'ё';
            char rightBoundaryYO = yo;

            char a = 'а';
            char leftBoundaryRussian = --a;
            char ya = 'я';
            char rightBoundaryRussian = ++ya;

            string inputString = $"{leftBoundaryYO}{rightBoundaryYO}{leftBoundaryRussian}{rightBoundaryRussian}";
            Assert.ThrowsException<InvalidSymbolStringException>(() => Program.InputStringCheck(inputString));
        }

        [TestMethod]
        public void StringTranslit_RussianEnglish_SimpleWord()
        {
            string stringForTranslit = "абвгдек";
            string expected = "abvgdek";

            StringTransliterator stringTransliterator = new StringTransliterator();
            string actual = stringTransliterator.StringTranslit(stringForTranslit);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringTranslit_RussianEnglish_LettersToCombination()
        {
            string stringForTranslit = "ёжхцчшщюя";
            string expected = "yozhkhtschshschyuya";

            StringTransliterator stringTransliterator = new StringTransliterator();
            string actual = stringTransliterator.StringTranslit(stringForTranslit);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringTranslit_EnglishRussian_SimpleWord()
        {
            string stringForTranslit = "ptokan";
            string expected = "птокан";

            StringTransliterator stringTransliterator = new StringTransliterator();
            string actual = stringTransliterator.StringTranslit(stringForTranslit);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringTranslit_EnglishRussian_CombinationToLetters()
        {
            string stringForTranslit = "yozhkhtschshschyuya";
            string expected = "ёжхцчшщюя";

            StringTransliterator stringTransliterator = new StringTransliterator();
            string actual = stringTransliterator.StringTranslit(stringForTranslit);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("ydr", "ыдр")]
        [DataRow("dyr", "дыр")]
        [DataRow("dry", "дры")]
        [DataRow("adr", "адр")]
        [DataRow("dar", "дар")]
        [DataRow("dra", "дра")]
        [DataRow("udr", "удр")]
        [DataRow("dur", "дур")]
        [DataRow("dru", "дру")]
        [DataRow("sdr", "сдр")]
        [DataRow("dsr", "дср")]
        [DataRow("drs", "дрс")]
        [DataRow("chdr", "чдр")]
        [DataRow("dchr", "дчр")]
        [DataRow("drch", "дрч")]
        [DataRow("tdr", "тдр")]
        [DataRow("dtr", "дтр")]
        [DataRow("drt", "дрт")]
        [DataRow("sdr", "сдр")]
        [DataRow("dsr", "дср")]
        [DataRow("drs", "дрс")]
        [DataRow("kdr", "кдр")]
        [DataRow("dkr", "дкр")]
        [DataRow("drk", "дрк")]
        [DataRow("zdr", "здр")]
        [DataRow("dzr", "дзр")]
        [DataRow("drz", "дрз")]
        [DataRow("odr", "одр")]
        [DataRow("dor", "дор")]
        [DataRow("dro", "дро")]
        public void StringTranslit_EnglishRussian_SymbolsContainedInCombinations(string stringForTranslit, string expected)
        {
            StringTransliterator stringTransliterator = new StringTransliterator();
            string actual = stringTransliterator.StringTranslit(stringForTranslit);

            Assert.AreEqual(expected, actual);
        }
    }
}
