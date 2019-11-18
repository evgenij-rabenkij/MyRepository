using System;

namespace CharacterSequence
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            Console.Write("Input string: ");
            inputString = Console.ReadLine();
            Console.WriteLine($"1. Maximal mumber of nonidentical consecutive characters: {GetMaxNumberOfNonidenticalConsecutiveCharacters(inputString)}");
            Console.WriteLine($"2. Maximal mumber of identical consecutive numbers: {GetMaxNumberOfIdenticalConsecutiveNumbers(inputString)}");
            Console.WriteLine($"3. Maximal mumber of nidentical consecutive latin characters: {GetMaxNumberOfIdenticalConsecutiveLatinCharacters(inputString)}");
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

        public static int GetMaxNumberOfIdenticalConsecutiveNumbers(string inputString)//method for getting maximal mumber of identical consecutive numbers
        {
            int maxNumber = 0;
            int helper = 0;
            int signal1 = 0;
            int signal2 = 0;

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                signal2++;//loop entry signal (string contains more then one symbol)

                if ((inputString[i+1] <= '9' && inputString[i+1] >= '0') || (inputString[i] <= '9' && inputString[i] >= '0'))
                {
                    signal1++;//if entry signal (string contains one or more numbers)
                    
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
            
            if (maxNumber != 0 || signal1 != 0)//condition of existing in string one or more number
            {
                maxNumber++;
            }
            
            if (signal2 == 0 && inputString[0] <= '9' && inputString[0] >= '0')//condition of string containing one numeric element
            {
                maxNumber++;
            }

            return maxNumber;
        }

        public static int GetMaxNumberOfIdenticalConsecutiveLatinCharacters(string inputString)//method for getting maximal mumber of nidentical consecutive latin characters
        {
            int maxNumber = 0;
            int helper = 0;
            int signal1 = 0;
            int signal2 = 0;

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                signal2++;//loop entry signal (string contains more then one symbol)

                if ((inputString[i + 1] <= 'z' && inputString[i + 1] >= 'a') || (inputString[i] <= 'z' && inputString[i] >= 'a'))
                {
                    signal1++;//if entry signal (string contains one or more latin symbols)

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
            
            if (maxNumber != 0 || signal1 != 0)//condition of existing in string one or latin symbol
            {
                maxNumber++;
            }
            
            if (signal2 == 0 && inputString[0] <= 'z' && inputString[0] >= 'a')//condition of string containing one latin symbol
            {
                maxNumber++;
            }
            
            return maxNumber;
        }
    }
}
