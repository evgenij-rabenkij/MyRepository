using System;

namespace StringTranslit
{
    public class Program
    {
        static void Main(string[] args)
        {
            string stringForTranslit = InputString();
            StringTransliterator stringTransliterator = new StringTransliterator();
            Console.WriteLine("Transliteration: " +  stringTransliterator.StringTranslit(stringForTranslit));
            Console.WriteLine("Reverse transliteration: " + stringTransliterator.StringTranslit(stringTransliterator.StringTranslit(stringForTranslit))); 
        }

        static string InputString()//method for inputting new string and calling check out method
        {
            string inputString;

            while (true)
            {
                try
                {
                    Console.Write("Enter string: ");
                    inputString = Console.ReadLine();
                    InputStringCheck(inputString);
                    return inputString;
                }
                catch (ZeroLengthStringException ex)
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
                catch (RussianAndEnglishSymbolsStringException ex)
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
            }
        }

        public static bool InputStringCheck(string checkedString)//method for checking input string and throwing appropriate exception in case of invalidity
        {
            if (checkedString.Length == 0)
            {
                throw new ZeroLengthStringException("Input string has a zero length. ");
            }

            int russianSymbolsCounter = 0;
            int englishSymbolsCounter = 0;
            
            foreach (char symbol in checkedString)
            {
                if (symbol <= 'z' && symbol >= 'a')
                {
                    englishSymbolsCounter++;
                }
                else if ( (symbol <= 'я' && symbol >= 'а') || symbol == 'ё'  )
                {
                    russianSymbolsCounter++;
                }
                else
                {
                    throw new InvalidSymbolStringException("Input string contains invailid symbol. ");
                }
            }

            if (englishSymbolsCounter != 0 && russianSymbolsCounter != 0)
            {
                throw new RussianAndEnglishSymbolsStringException("Input string contains russian and english symbols at the same time.");
            }

            return true;
        }
    }
}
