// Q10. Buid a class with the following
// - 2 properties which are integer types
// - 1 property should accept only values which are postives
// - 1 property should accept only values which are negatives

using System;



public class NumberProperties

{

    private int positiveNumber;

    private int negativeNumber;
    // Property for positive values 
    public int PositiveNumber
    {
        get { return positiveNumber; }
        set
        {
            if (value >= 0)
            {
                positiveNumber = value;
                Console.WriteLine(PositiveNumber);
            }
            else
            {
                Console.WriteLine("Error: PositiveNumber must be a non-negative value.");
            }
        }
    }
    // Property for negative values 

    public int NegativeNumber
    {
        get { return negativeNumber; }
        set
        {
            if (value < 0)
                negativeNumber = value;
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the class 
        NumberProperties numbers = new NumberProperties();
        // Set positive and negative value 
        numbers.PositiveNumber = 42;
        numbers.NegativeNumber = -10;

        // Try setting invalid values 
        numbers.PositiveNumber = -5; // This should display an error message 
        numbers.NegativeNumber = 8;  // This should display an error message
        Console.WriteLine(numbers.PositiveNumber + "-" + numbers.NegativeNumber);
        Console.ReadLine();
    }

}