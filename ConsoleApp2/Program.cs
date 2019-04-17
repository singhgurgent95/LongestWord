using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
        
            static void Main(string[] args)
            {
                Program a = new Program();
                Console.WriteLine("the longest world is :");
                Console.WriteLine(a.MyFunctionA("ada lovelace wrote the first algorith desingned for processing bt an Analytical Engine."));
            }

            private bool MyFunctionA(string v)
            {
                throw new NotImplementedException();
            }

            public MyFunctionA(string input)
            {
                // Write a C# prograam to find the longest word in a string.
                string[] words = input.Split('');
        int wordArrayLength = words.Length;
        int[] wordsLength = new int[wordArrayLength];
        int x = 0;

        foreach (var word in words)
        {
            //TODO
        }
        //loop post condition: we now have  array wordsLength which
        // contain the length of each word

        string currentWord = words[0];
        string nextWord;
        string longestWord = currentWord;

        for (int y = 0; y < words.Length - 1; y++)
        {

        }
        }
}
