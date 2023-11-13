// Write a C# program that checks if a given number(manage it as User Input) is positive or
// negative using if-else statements.


using System;

public class test{
    public static void Main(){
        int num;
        Console.Write("Enter Number: ");
        num = int.Parse(Console.ReadLine());

        if (num>0){
            Console.WriteLine(num+" is Positive");
        }
        else{
            Console.WriteLine(num+" is Negative");
        }
    }

}