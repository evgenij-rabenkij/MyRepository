using System;

namespace StringCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string str;
                    str = Console.ReadLine();
                    CheckRussianStringValidity(str);
                    int v = str.VowelsCount();
                    Console.WriteLine("Гласные: " + v);
                    int c = str.ConsonantsCount();
                    Console.WriteLine("Согласные: " + c);
                    string r = str.StringReverse();
                    Console.WriteLine("перевёртыш: " + r);
                    break;
                }
                catch (NotRussianSymbolException ex)
                {
                    Console.WriteLine(ex.Message + "Try again");
                }
            }

            static void CheckRussianStringValidity(string str)//method for checking russian symbols
            {
                str = str.ToLower();
                string symbols = ".,:;! ";
                for (int i = 0; i < str.Length; i++)
                {
                    if ((str[i] >= 'а' && str[i] <= 'я') || symbols.Contains(str[i]))
                    {

                    }
                    else
                    {
                        throw new NotRussianSymbolException("Not russian symbol.");
                    }
                }
            }
        }
    }
}
    

