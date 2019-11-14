using System.Text;

namespace StringCheck
{
    public static class StringHelper
    {
        const string vowels = "аоуеёияэюы";
        const string consonants = "бвгджзйклмнпрстфхцчшщ";

        public static int VowelsCount(this string str)//method for counting vowels
        {
            str = str.ToLower();
            return CountMutualSymbols(vowels, str);
        }

        public static int ConsonantsCount(this string str)//method for counting consonants
        {
            str = str.ToLower();
            return CountMutualSymbols(consonants, str);
        }

        private static int CountMutualSymbols(string str1, string str2)//method for counting cymbols in string
        {
            int vow = 0;
            foreach (var smb in str2)
            {
                if (str1.Contains(smb))
                {
                    vow++;
                }
            }
            return vow;
        }

        public static string StringReverse(this string str)//metod for reversing string
        {
            StringBuilder revertString = new StringBuilder();
            for (int i = str.Length-1; i>=0; i--)
            {
                revertString.Append(str[i]);
            }
            return revertString.ToString();
        }
    }
}
