



class Program

{

    static string remove(string input)

    {

        string temp = "";

        for (int i = 0; i < input.Length; i++)

        {

            if (i % 2 == 0)

            {

                temp += input[i];

            }

        }

        return temp;



    }

    static string removechar(string input)

    {

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)

        {

            words[i] = remove(words[i]);

        }

        return string.Join(" ", words);



    }

    static void Main(string[] args)

    {

        Console.WriteLine("Enter a Sentences");

        string input = Console.ReadLine();

        string final_output = removechar(input);

        Console.WriteLine("Output:");

        Console.WriteLine(final_output);

    }

}
