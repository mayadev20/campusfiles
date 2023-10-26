// Develop a C# program that accept numeric values and sort them in Descending Order. 

using System;

public class DescOrder {

    public static void Main(){
        int[] Num2 = new int[4];
        
        for (int i=0; i<4; i++){
            Console.Write("Enter Number ");
            Num2[i]=int.Parse(Console.ReadLine());
            Array.Sort(Num2);
            Array.Reverse(Num2);
        
        }

        foreach (int k in Num2){
            Console.Write(k+" ");
        }
        
    }
}