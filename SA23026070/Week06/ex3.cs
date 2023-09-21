// Write a C# program that checks if a given number(manage it as User Input) is even or
// odd using if-else statements.

using System;

public class oddeven{
    public static void Main(){
        int num;
        Console.Write("Enter Number: ");
        num = int.Parse(Console.ReadLine());

        if (num%2==0){
            Console.WriteLine(num+" is Even");
        }
        else{
            Console.WriteLine(num+" is Odd");
        }

    }
}