using System;
using System.Linq;

namespace _04.substrings
{
    class Program
    {
        static void Main()
        {
            string text = "PesHo";
            Console.WriteLine(text);
            text =
                 text.ToLower(); //take teh opls text string and assigns the new all low Symbols! 
            Console.WriteLine(text); //resutl all is low cased !!!
            text = text.ToUpper(); //takes the text and converts it to upperCase all!
            Console.WriteLine(text);
        }
    }
}
