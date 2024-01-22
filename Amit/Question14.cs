using System;



// Base class 

class Patient

{

    public string Name { get; set; }

    public int Age { get; set; }



    // Overloaded method with different parameters 

    public void DisplayInfo()

    {

        Console.WriteLine($"Name: {Name}");

        Console.WriteLine($"Age: {Age}");

    }



    // Overridden method 

    public virtual void DisplayMedicalInfo()

    {

        Console.WriteLine("No specific medical information for a general patient.");

    }

}



// Derived class 

class SpecialPatient : Patient

{

    public string SpecialNote { get; set; }



    // Overloaded method with different parameters 

    public void DisplayInfo(string additionalInfo)

    {

        DisplayInfo(); // Call the base class method 

        Console.WriteLine($"Additional Info: {additionalInfo}");

    }



    // Override the base class method 

    public override void DisplayMedicalInfo()

    {

        base.DisplayMedicalInfo(); // Call the base class method 

        Console.WriteLine($"Special Note: {SpecialNote}");

    }

}



class Program

{

    static void Main()

    {

        // Creating an instance of the base class 

        Patient patient1 = new Patient { Name = "Amit kumar", Age = 25 };



        // Calling overloaded method in the base class 

        Console.WriteLine("Base Class Overloaded Method Output:");

        patient1.DisplayInfo();



        Console.WriteLine("\n========================\n");



        // Creating an instance of the derived class 

        SpecialPatient specialPatient1 = new SpecialPatient { Name = "Ak verma", Age = 30, SpecialNote = "Needs special care" };



        // Calling overloaded method in the derived class 

        Console.WriteLine("Derived Class Overloaded Method Output:");

        specialPatient1.DisplayInfo("High Priority");



        Console.WriteLine("\n========================\n");



        // Calling overridden method in the derived class 

        Console.WriteLine("Derived Class Overridden Method Output:");

        specialPatient1.DisplayMedicalInfo();

    }

}