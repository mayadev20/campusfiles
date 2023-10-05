using System;

class agecategory {
    public static void Main(){
        int age;
        string result;

        Console.WriteLine("Enter Your Age");
        age=int.Parse(Console.ReadLine());

        result = (age>20) ? "Adult" : (age>=13) ? "Teenagers" : "Child";
        Console.WriteLine(result);
    
    }
}