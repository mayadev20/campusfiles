// Get the summation of numbers in between 3 to 12, using for loop.
using System;

public class sumofnum{

    public static void Main(){

        int total=0;
        for (int num=3; num<=12; num=num+1){
            total=total+num;
        }
        Console.WriteLine("Total is "+total);
        
}}