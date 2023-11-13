// Write a C# program to check a villager is eligible for vaccination. The eligibility criteria is,
// all villagers needs to be 60 or grater than 60 of the age. Use if statement. 

using System;

public class vaccination{
    public static void Main(){
        int age;

        Console.Write("Enter Age: ");
        age = int.Parse(Console.ReadLine());

        if (age>=60){
            Console.WriteLine("Eligible for Vaccination");
        }
        
    }

}