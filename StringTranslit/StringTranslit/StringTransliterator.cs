using System.Text;

namespace StringTranslit
{
    public class StringTransliterator//class contains methods for determination language of string, transliteration and reverse transliteration string

    {
        public StringTransliterator()
        { 
        }

        public string StringTranslit(string stringForTranslit)//method for determine languge of string and calling appropriate transliteration method
        {
            if ( (stringForTranslit[0] <= 'я' && stringForTranslit[0] >= 'а') || stringForTranslit[0] == 'ё')
            {
                return RussianEnglishTranslit(stringForTranslit);
            }
            else
            {
                return EnglishRussianTranslit(stringForTranslit) ;
            }
        }

        static string RussianEnglishTranslit(string stringForTranslit)// method for transliteration 
        {
            StringBuilder translitedString = new StringBuilder();
            foreach (char symbol in stringForTranslit)
            {
                switch (symbol)
                {
                    case 'а':
                        translitedString.Append('a');
                        break;
                    case 'б':
                        translitedString.Append('b');
                        break;
                    case 'в':
                        translitedString.Append('v');
                        break;
                    case 'г':
                        translitedString.Append('g');
                        break;
                    case 'д':
                        translitedString.Append('d');
                        break;
                    case 'е':
                        translitedString.Append('e');
                        break;
                    case 'ё':
                        translitedString.Append("yo");
                        break;
                    case 'ж':
                        translitedString.Append("zh");
                        break;
                    case 'з':
                        translitedString.Append('z');
                        break;
                    case 'и':
                        translitedString.Append('i');
                        break;
                    case 'й':
                        translitedString.Append('y');
                        break;
                    case 'к':
                        translitedString.Append('k');
                        break;
                    case 'л':
                        translitedString.Append('l');
                        break;
                    case 'м':
                        translitedString.Append('m');
                        break;
                    case 'н':
                        translitedString.Append('n');
                        break;
                    case 'о':
                        translitedString.Append('o');
                        break;
                    case 'п':
                        translitedString.Append('p');
                        break;
                    case 'р':
                        translitedString.Append('r');
                        break;
                    case 'с':
                        translitedString.Append('s');
                        break;
                    case 'т':
                        translitedString.Append('t');
                        break;
                    case 'у':
                        translitedString.Append('u');
                        break;
                    case 'ф':
                        translitedString.Append('f');
                        break;
                    case 'х':
                        translitedString.Append("kh");
                        break;
                    case 'ц':
                        translitedString.Append("ts");
                        break;
                    case 'ч':
                        translitedString.Append("ch");
                        break;
                    case 'ш':
                        translitedString.Append("sh");
                        break;
                    case 'щ':
                        translitedString.Append("sch");
                        break;
                    case 'ы':
                        translitedString.Append('y');
                        break;
                    case 'э':
                        translitedString.Append('e');
                        break;
                    case 'ю':
                        translitedString.Append("yu");
                        break;
                    case 'я':
                        translitedString.Append("ya");
                        break;
                    default:
                        break;
                }
            }
            return translitedString.ToString();
        }

        static string EnglishRussianTranslit(string stringForTranslit)//method for reverse transliteration
        {
            StringBuilder translitedString = new StringBuilder();

            for (int i = 0; i < stringForTranslit.Length; i++)
            {
                switch (stringForTranslit[i])
                {
                    case 'y':
                        if (i != stringForTranslit.Length - 1)
                        {
                            switch (stringForTranslit[i + 1])
                            {
                                case 'o':
                                    translitedString.Append('ё');
                                    i++;
                                    break;
                                case 'u':
                                    translitedString.Append('ю');
                                    i++;
                                    break;
                                case 'a':
                                    translitedString.Append('я');
                                    i++;
                                    break;
                                default:
                                    translitedString.Append('ы');
                                    break;
                            }
                        }
                        else
                        {
                            translitedString.Append('ы');
                        }
                        break;

                    case 'z':
                        if (i != stringForTranslit.Length - 1)
                        {
                            switch (stringForTranslit[i + 1])
                            {
                                case 'h':
                                    translitedString.Append('ж');
                                    i++;
                                    break;
                                default:
                                    translitedString.Append('з');
                                    break;
                            }
                        }
                        else
                        {
                            translitedString.Append('з');
                        }
                        break;

                    case 'k':
                        if (i != stringForTranslit.Length - 1)
                        {
                            switch (stringForTranslit[i + 1])
                            {
                                case 'h':
                                    translitedString.Append('х');
                                    i++;
                                    break;
                                default:
                                    translitedString.Append('к');
                                    break;
                            }
                        }
                        else
                        {
                            translitedString.Append('к');
                        }
                        break;

                    case 't':
                        if (i != stringForTranslit.Length - 1)
                        {
                            switch (stringForTranslit[i + 1])
                            {
                                case 's':
                                    translitedString.Append('ц');
                                    i++;
                                    break;
                                default:
                                    translitedString.Append('т');
                                    break;
                            }
                        }
                        else 
                        {
                            translitedString.Append('т');
                        }
                        break;

                    case 's':
                        if (i != stringForTranslit.Length - 1)
                        {
                            switch (stringForTranslit[i + 1])
                            {
                                case 'h':
                                    translitedString.Append('ш');
                                    i++;
                                    break;
                                case 'c':
                                    translitedString.Append('щ');
                                    i += 2;
                                    break;
                                default:
                                    translitedString.Append('с');
                                    break;
                            }
                        }
                        else 
                        {
                            translitedString.Append('с');
                        }
                        break;

                    case 'a':
                        translitedString.Append('а');
                        break;
                    case 'b':
                        translitedString.Append('б');
                        break;
                    case 'v':
                        translitedString.Append('в');
                        break;
                    case 'g':
                        translitedString.Append('г');
                        break;
                    case 'd':
                        translitedString.Append('д');
                        break;
                    case 'e':
                        translitedString.Append('е');
                        break;
                    case 'i':
                        translitedString.Append('и');
                        break;
                    case 'l':
                        translitedString.Append('л');
                        break;
                    case 'm':
                        translitedString.Append('м');
                        break;
                    case 'n':
                        translitedString.Append('н');
                        break;
                    case 'o':
                        translitedString.Append('о');
                        break;
                    case 'p':
                        translitedString.Append('п');
                        break;
                    case 'r':
                        translitedString.Append('р');
                        break;
                    case 'u':
                        translitedString.Append('у');
                        break;
                    case 'f':
                        translitedString.Append('ф');
                        break;
                    default:
                        break;
                    case 'c':
                        translitedString.Append('ч');
                        i++;
                        break;
                }
            }
                return translitedString.ToString();
        }
    }
}
