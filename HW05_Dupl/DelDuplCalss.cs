using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace DelDuplNS
{
    public partial class DelDupl
    {
        [StringSyntax(StringSyntaxAttribute.Regex)]
        const string patern = 
                @"
                    \b          #начало слова
                    (\w+?)      #посик последовательности из печатных символов длинной 1 и более символов в режиме lazy (минимальное колличество)
                    (    
                    \s+         #1 и более пробельных символов
                    \1          #повтор первой группы (слова)
                    )+          #поиск 1 и более повторяющихся слов после группы 1
                ";

        [GeneratedRegex(patern, RegexOptions.IgnorePatternWhitespace)]
        private static partial Regex regexGen();

        private static Regex regexComp = new Regex(patern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);

        private static Regex regexNonComp = new Regex(patern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

        public static string DelGen(string input)
        {
            return regexGen().Replace(input, "$1");
        }

        public static string DelComp(string input)
        { 
            return regexComp.Replace(input, "$1");
        }   

        public static string DelNonComp(string input)
        {
            return regexNonComp.Replace(input, "$1");
        }


    }
}
