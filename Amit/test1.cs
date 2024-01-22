using System;

class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Enter a sentences:");

        string input = Console.ReadLine();

        string output = ConvertFirstLetterToUpper(input);

        //ConvertFirstLetterToUpper(input); 

        Console.WriteLine(output);

    }

    static string ConvertFirstLetterToUpper(string input)

    {

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)

        {

            if (!string.IsNullOrEmpty(words[i]))

            {

                char[] wordschar = words[i].ToCharArray();

                wordschar[0] = char.ToUpper(wordschar[0]);

                words[i] = new string(wordschar);

            }

        }

        return string.Join(" ", words);

    }

}
