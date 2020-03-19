using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Strings
    {
        public static void Palindrome()
        {
            Console.WriteLine("Enter a word and I will check whether it's a palindrome or not");
            string str = Console.ReadLine().ToLower();
            char[] s = str.ToCharArray();
            Array.Reverse(s);
            string temp = new string(s);
            if (temp.Equals(str))
                Console.WriteLine("String is a palindrome");
            else Console.WriteLine("Not a palindrome");
        }
        public static void CountWordsInSentence()
        {
            Console.WriteLine("Enter a sentence:");
            string[] sentence = Console.ReadLine().Split(' ');
            for(int i = 0; i < sentence.Length; i++)
                Console.Write(sentence[i] + " ");
            Console.WriteLine();
            Console.WriteLine(sentence.Length);
        }
        public static void FindAndReplaceString()
        {
            Console.WriteLine("Enter some text ->");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("\nYour text:\n" + text + "\n\n" + 
                "Enter a sentence which you want to replace ->\n");
            string replaceStr = Console.ReadLine().ToLower();
            if(text.Contains(replaceStr)) {
                Console.WriteLine("\nEnter a sentence to replace ->");
                string sentence = Console.ReadLine().ToLower();
                text = text.Replace(replaceStr, sentence);
                Console.WriteLine("\nNew text ->\n" + text);
            }
            else {
                Console.WriteLine("\nThere's no such sentence!");
                return;
            }
        }
        public static void ReplaceWords()
        {
            // replace neighboring words in text
            Console.WriteLine("Enter some text ->\n");
            string[] sentence = Console.ReadLine().Split(' ');
            for(int i = 0; i < sentence.Length - 1; i++) {
                string temp = sentence[i];
                sentence[i] = sentence[i + 1];
                sentence[i + 1] = temp;
                i++;
            }
            Console.WriteLine("\nNew text with replaced neighboring words ->\n");
            foreach(var s in sentence) {
                Console.Write(s + " ");
            }
            Console.WriteLine("\n");
        }
        public static void Vowels()
        {
            // find and count words ending with vowels in text
            string vowels = "АаУуЕеЯяИиОоЭэЮюAaEeUuIiOo";
            Console.WriteLine("Enter text ->\n");
            string text = Console.ReadLine();
            int count = 0;
            foreach(string word in text.Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)) {
                if(vowels.IndexOf(word[word.Length - 1]) >= 0) {
                    Console.WriteLine(word);
                    count++;
                }
            }
            Console.WriteLine("Count of words ending with vowels: " + count);
        }

        static void Main(string[] args)
        {
            Vowels();
        }
    }
}
