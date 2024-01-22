
// Write a program where in a sentence is accepted and each word's first alphabet to be
// converted to upper case
// eg: Input: welcome to simplify3x software development company
// Output: Welcome To Simplify3x Software Development Company

using System;
namespace Test3
{

    partial class Program
    {
        
        static string CapitalizeFirstLetterOfWord(string word)
        {
            
            char[] letters = word.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }

        static string CapitalizeFirstLetterOfEachWord(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                   words[i] = CapitalizeFirstLetterOfWord(words[i]);
            }
            return string.Join(" ", words);
        }

        static partial void FirstLetterUpper()
        {
            Console.Write("Enter a sentence : ");
            string inputSentence = Console.ReadLine();
            string capitalizedSentence = CapitalizeFirstLetterOfEachWord(inputSentence);
            Console.Write("Output : ");
            Console.WriteLine(capitalizedSentence+"\n\n");
        }

    }
}