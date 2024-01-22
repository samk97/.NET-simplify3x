// Q13. Write a program where in a sentence is accepted and each words alternative character
// needs to be removed
// eg: Input: welcome to simplify3x software development company
// Output: wloe t smlf3 sfwr dvlpet cmay

namespace Test3;

partial class Program
{
    //Use stringbuilder instead of string
    static string removeChar(string word)
    {
        
        string temp = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (i % 2 == 0)
                temp += word[i];
        }
        return temp;
    }
    static string AlternativeChar(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            
            words[i] = removeChar(words[i]);
            
        }
        return string.Join(" ", words);
    }

    static partial void AltChar()
    {
        Console.Write("Enter a sentence : ");
        string inputSentence = Console.ReadLine();
        string alternativeSentance = AlternativeChar(inputSentence);
        Console.Write("Output : ");
        Console.WriteLine(alternativeSentance+"\n\n");
    }


}
