using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringHelper
    {
        public static string Shorten(this string text, int numberOfWords)
        {
            if(numberOfWords <= 0)
            {
                return "";
            }
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }
            string[] words = text.Split(' ');

            if (words.Length < numberOfWords)
            {
                return text;
            }
            
            List<string> resultWords = words.Take(numberOfWords).ToList();

            string result = string.Join(" ", resultWords);
            return result;
        }
    }
}
