using System;

namespace Test3
{
    partial class Program
    {

        static partial void Palindrome();
        static partial void FirstLetterUpper();
        static partial void AltChar();
        static partial void findWeek();

        private static void Main(string[] args)
        {
            // Call the partial method

            while (true)
            {
                Console.WriteLine("1. Palindrome check.");
                Console.WriteLine("2. First alphabet to be converted to upper case.");
                Console.WriteLine("3. Remove alternative character.");
                Console.WriteLine("4. Find week of the year.");
                Console.WriteLine("5. exit.");
                Console.Write("Enter your choice : ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Palindrome();
                        break;
                    case 2:
                        FirstLetterUpper();
                        break;
                    case 3:
                        AltChar();
                        break;
                    case 4:
                        findWeek();
                        break;
           

                    default:
                        System.Environment.Exit(1);
                        break;

                }
                
                
                
                
            }
        }
    }
}
