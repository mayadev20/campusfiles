// Write a simple C# program that stores following integer elements in an array and
// prints them at the Console Screen.
// 32 85 41 37 12 77

using System;

public class ArrayPrint {

    public static void Main(){
        //int[] oneD = new int[6] {32,85,41,37,12,77};
        int[] oneD = new int[6];
        int i;

        Console.WriteLine("Enter Numbers");
    
        for (i=0; i<6; i++){
            oneD[i]=int.Parse(Console.ReadLine());
        }

        Console.WriteLine("-----------");
        foreach (int j in oneD){
            Console.Write(j+" ");
        }
        
    }
}