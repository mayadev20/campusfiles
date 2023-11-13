// Write a C# program that uses a do-while loop to ask the user for a password until they
// enter the correct one. The correct password is "12345"

using System;

public class password{

    public static void Main(){

        int pass=1234,userinput;
        do{
            Console.Write("Enter Password");
            userinput=int.Parse(Console.ReadLine());
        }while (userinput!=pass);

        Console.WriteLine("Welcome");
        
}}