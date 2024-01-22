using System;



class Program

{

    static bool isPlaindrome(string input)

    {

        int i = 0, j = input.size() - 1;

        While(i <= j){

            if(input[i] != input[j]){

                Return false;
                }
            i++;
             J--;
             retrun true;
            }

        static void Main(string[] args)

        {

            Console.WriteLine("Enter the number:");

            String input = Console.ReadLine();


            if (isPlaindrome(input)){
                     Console.WriteLine("this is the plaindrome number");
                }
                else{
                  Console.WriteLine("this is not a plaindrome number");
                  }

        }

    }
