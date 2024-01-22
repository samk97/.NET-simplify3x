
// Q8. Build a class with the following
// - 2 properties which are readonly
// - 2 methods which are overloaded
public class Patient

{

    // Properties 

    public string Name { get; }

    public int Age { get; }



    // Constructor to initialize patient information 

    public Patient(string patientName, int patientAge)

    {

        Name = patientName;

        Age = patientAge;

    }



    // Display basic patient information 

    public void DisplayBasicInfo()

    {

        Console.WriteLine($"Patient Name: {Name}, Age: {Age}");

    }



    // Display patient information with additional medical details 

    public void DisplayMedicalInfo(string medicalCondition)

    {

        Console.WriteLine($"Patient Name: {Name}, Age: {Age}, Medical Condition: {medicalCondition}");

    }

}



class HospitalProgram

{

    static void Main()

    {

        // Create a patient instance 

        Patient patient1 = new Patient("John Doe", 45);



        // Display basic patient information 

        Console.WriteLine("Basic Patient Information:");

        patient1.DisplayBasicInfo();



        // Display patient information with medical details 

        Console.WriteLine("\nPatient Information with Medical Condition:");

        patient1.DisplayMedicalInfo("Undergoing treatment for a respiratory infection.");
        Console.ReadLine();
    }

}

