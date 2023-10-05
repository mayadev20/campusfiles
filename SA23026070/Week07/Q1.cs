using System;

class vaccination {
    public static void Main(){
        int age;
        string result;

        Console.WriteLine("Enter Your Age");
        age=int.Parse(Console.ReadLine());

        result = (age>=60) ? "Eligible" : "Not eligible";
        Console.WriteLine(result);
    
    }
}