using System;

namespace Prac4
{
    public class Program
    {
        private static void Main()
        {
            string words = "level ill pop level radar madam refer";
            var wordArr = words.Split(' ');
            bool exists = false;

            Console.WriteLine($"All the words: {words}.");
            Console.WriteLine("The symmetrical words, not equal to the first, with non-repeating letters: ");

            foreach (string word in wordArr)
            {
                if (word != wordArr.First() && word == new string(word.Reverse().ToArray()) && word.Distinct().Count() == word.Length)
                {
                    Console.WriteLine(word);

                    exists = true;
                }
            }

            if (!exists) Console.WriteLine("THERE ARE NO SUCH WORDS!");
        }
    }
}