// Write a C# program to find the maximum element in an array of integers.

using System;

public class Maxnum {

    public static void Main(){
        int[] Num1 = new int[4];
        int max=0;
        
        for (int i=0; i<4; i++){
            Console.Write("Enter Number ");
            Num1[i]=int.Parse(Console.ReadLine());
            
            if (Num1[i]>max){
                max=Num1[i];
            }
        }
        Console.WriteLine("\nMaximum Number is: "+max);
        
    }
}