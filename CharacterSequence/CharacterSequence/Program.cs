using System;

namespace CharacterSequence
{
    public class Program
    {
        public delegate bool SymbolDetermination(char symbol);
        static void Main(string[] args)
        {
            string inputString;
            Console.Write("Input string: ");
            inputString = Console.ReadLine();
            Console.WriteLine($"1. Maximal mumber of nonidentical consecutive characters: {GetMaxNumberOfNonidenticalConsecutiveCharacters(inputString)}");
            SymbolDetermination isNumber = IsNumber;
            Console.WriteLine($"2. Maximal mumber of identical consecutive numbers: {GetMaxNumberOfIdenticalConsecutiveSymbols(inputString, isNumber)}");
            SymbolDetermination isLatin = IsLatin;
            Console.WriteLine($"3. Maximal mumber of unidentical consecutive latin characters: {GetMaxNumberOfIdenticalConsecutiveSymbols(inputString, isLatin)}");
        }

        public static int GetMaxNumberOfNonidenticalConsecutiveCharacters(string inputString)//method for getting maximal mumber of nonidentical consecutive characters
        {
            int maxNumber = 0;
            int helper = 0;
            
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] != inputString[i + 1])
                {
                    helper++;
                }
                else if (helper > maxNumber)
                {
                    maxNumber = helper;
                    helper = 0;
                }
                else 
                {
                    helper = 0;
                }
            }

            if (helper > maxNumber)//last checkout of maximal value
            {
                maxNumber = helper;
            }

            return ++maxNumber;
        }

        public static int GetMaxNumberOfIdenticalConsecutiveSymbols(string inputString, SymbolDetermination symbolDeterminant)//method for getting maximal mumber of identical consecutive numbers and latin symbols
        {
            int maxNumber = 0;
            int helper = 0;
            int signal1 = 0;
            int signal2 = 0;

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                signal2++;//loop entry signal (string contains more then one symbol)

                if ( symbolDeterminant(inputString[i + 1])  || symbolDeterminant(inputString[i]))
                {
                    signal1++;//if entry signal (string contains one or more appropriates elements)

                    if (inputString[i] == inputString[i + 1])
                    {
                        helper++;
                    }
                    else if (helper > maxNumber)
                    {
                        maxNumber = helper;
                        helper = 0;
                    }
                    else
                    {
                        helper = 0;
                    }
                }
            }

            if (helper > maxNumber)//last checkout of maximal value
            {
                maxNumber = helper;
            }

            if (maxNumber != 0 || signal1 != 0)//condition of existing in string one or more appropriates elements
            {
                maxNumber++;
            }

            if (signal2 == 0 && symbolDeterminant(inputString[0]))//condition of string containing one appropriate element
            {
                maxNumber++;
            }

            return maxNumber;
        }

        public static bool IsLatin(char symbol)//method returns true if symbol is latin character
        {
            return symbol <= 'z' && symbol >= 'a';
        }

        public static bool IsNumber(char symbol)//method returns true if symbol is number
        {
            return symbol <= '9' && symbol >= '0';
        }
    }
}
