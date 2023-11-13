// Write a program to input 5 numbers as user inputs and print the sum and the average to
// the screen using for loop structure.

using System;

public class sumofinput{

    public static void Main(){

        double total=0,userinput,avg=0;
        
        for (int num=1; num<=5; num=num+1){
            Console.Write("Enter Number: ");
            userinput=double.Parse(Console.ReadLine());
            total=total+userinput;
            avg=total/5;
        }
        Console.WriteLine("Total is "+total+"\nAverage is "+avg);
        
}}