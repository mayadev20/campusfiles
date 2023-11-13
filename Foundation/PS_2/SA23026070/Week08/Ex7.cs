// Write a C# program that uses while loop to print the following pattern.
// 1
// 1 2
// 1 2 3
// 1 2 3 4

using System;

public class numpattern{

    public static void Main(){

        int row = 4,i=1;

        while (i<=row){
            int j=1;
            while(j<=i){
                Console.Write(j+" ");
                j++;
            }
            i++;
            Console.WriteLine();
        }
    }
}