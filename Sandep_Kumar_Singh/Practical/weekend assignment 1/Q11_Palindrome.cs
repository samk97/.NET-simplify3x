
// Q11. Write a program to accept a string and check whether its palindrome.

using System;

// Specify the namespace
namespace Test3
{

    partial class Program
    {

        static bool IsPalindrome(string str)
        {
            // Removing spaces and converting to lowercase for a case-insensitive check 
            string cleanedStr = str.Replace(" ", "").ToLower();
            int length = cleanedStr.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (cleanedStr[i] != cleanedStr[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static partial void Palindrome()
        {
            Console.Write("Enter a string to check whether its palindrome or not : ");
            string input = Console.ReadLine();
            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome.\n\n");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.\n\n");
            }
            
        }
    }
}
