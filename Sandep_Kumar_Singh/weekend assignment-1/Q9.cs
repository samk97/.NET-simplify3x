// Q9. Build a derived class where in
// - override the base class method functionality
// - Program which can call base class method and
// derived class method and check the output

using System;



// Base class 

public class Person

{

    // Properties 

    public string Name { get; }

    public int Age { get; }



    // Constructor to initialize person information 

    public Person(string name, int age)

    {

        Name = name;

        Age = age;

    }



    // Display basic person information 

    public virtual void DisplayInfo()

    {

        Console.WriteLine($"Person Name: {Name}, Age: {Age}");

    }

}



// Derived class 

public class Patient : Person

{

    // Properties specific to Patient 

    public string MedicalCondition { get; }



    // Constructor to initialize patient information 

    public Patient(string name, int age, string medicalCondition)

        : base(name, age)

    {

        MedicalCondition = medicalCondition;

    }



    // Override the base class method to include medical details 

    public override void DisplayInfo()

    {

        base.DisplayInfo(); // Call the base class method 

        Console.WriteLine($"Medical Condition: {MedicalCondition}");

    }

}



class HospitalProgram

{

    static void Main()

    {

        // Create a person instance 

        Person person = new Person("John Doe", 30);



        // Call the base class method 

        Console.WriteLine("Calling base class method for a person:");

        person.DisplayInfo();

        Console.WriteLine();



        // Create a patient instance 

        Patient patient = new Patient("Alice Smith", 45, "Undergoing treatment for a respiratory infection.");



        // Call the derived class method 

        Console.WriteLine("Calling derived class method for a patient:");

        patient.DisplayInfo();
        Console.ReadLine();
    }

}