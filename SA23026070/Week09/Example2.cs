using System;

public class Example {

    public static void Main(){
        int[] oneD = new int[4] {7,2,4,6};
        // int[,] twoD = new int[2,3] { {5,2,1},{7,9,4} };

        //Sort
        Array.Sort(oneD);
        Array.Reverse(oneD);
        
        foreach (int k in oneD){
            Console.Write(k+" ");
        }
    }
}