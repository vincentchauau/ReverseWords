using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static String reverseWords(String v)
        {
            // v = first word + multiple spaces + second word + multiple spaces ... + multiple spaces + last word
            Regex regex = new Regex("\\s+");
            String[] strings = regex.Split(v);
            String result = "";
            foreach (String s in strings)
            {
                result = s + " " + result;
            }
            // result = last word + space + second last word + space +... + first word + space;
            // result has single spaces between words, v has multiple spaces between words
            // result ends with single space, v is not sure to end with any space
            if (result == v)
                return null;
            return result;
        }
        public static string reverseWords2(string v)
        {
            // v = first word + multiple spaces + second word + multiple spaces ... + multiple spaces + last word
            Regex regex = new Regex("\\s+");
            string[] strings = regex.Split(v);
            string origin = "";
            string result = "";
            foreach (string s in strings)
            {
                origin = origin + s + " ";
                result = s + " " + result;
            }
            // origin = first word + space + second word + space + ... + last word + space
            // result = last word + space + second last word + space +... + first word + space;
            if (origin == result)
                return null;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(reverseWords("test why test"));
            Console.WriteLine(reverseWords2("test why test"));
        }
    }
}
