// Q14. write a program and take 2 classes (1 base class and 1 derived class) and each class
// should
// have overload and override methods and call them and it should work appropriately

using System;



class MathOperation

{

    public int Add(int a, int b)

    {

        return a + b;

    }



    public double Add(double a, double b)

    {

        return a + b;

    }



    public virtual void DisplayMessage()

    {

        Console.WriteLine("MathOperation - Base Class Message");

    }

}



class AdvancedMathOperation : MathOperation

{

    public int Multiply(int a, int b)

    {

        return a * b;

    }



    public double Multiply(double a, double b)

    {

        return a * b;

    }



    public override void DisplayMessage()

    {

        Console.WriteLine("AdvancedMathOperation - Derived Class Message");

    }

}



class Program

{

    static void Main()

    {

        MathOperation mathObj = new MathOperation();

        AdvancedMathOperation advancedMathObj = new AdvancedMathOperation();



        // Overload methods from the base class 

        Console.WriteLine("Overloaded methods from MathOperation (Base Class):");

        Console.WriteLine($"Add(int): {mathObj.Add(5, 3)}");

        Console.WriteLine($"Add(double): {mathObj.Add(2.5, 3.5)}");

        Console.WriteLine();



        // Override methods in the derived class 

        Console.WriteLine("Overridden methods from AdvancedMathOperation (Derived Class):");

        Console.WriteLine($"Add(int): {advancedMathObj.Add(5, 3)}");

        Console.WriteLine($"Add(double): {advancedMathObj.Add(2.5, 3.5)}");

        Console.WriteLine($"Multiply(int): {advancedMathObj.Multiply(5, 3)}");

        Console.WriteLine($"Multiply(double): {advancedMathObj.Multiply(2.5, 3.5)}");

        Console.WriteLine();



        // Call overridden method from the base class 

        Console.WriteLine("Overridden method from the base class:");

        mathObj.DisplayMessage();

        Console.WriteLine();



        // Call overridden method from the derived class 

        Console.WriteLine("Overridden method from the derived class:");

        advancedMathObj.DisplayMessage();

    }

}

