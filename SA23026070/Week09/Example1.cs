using System;

public class Example {

    public static void Main(){
        int[] oneD = new int[4] {7,2,4,6};
        int[,] twoD = new int[2,3] { {5,2,1},{7,9,4} };

        Console.WriteLine("1D Length:"+ oneD.Length);
        Console.WriteLine("1D Length(0):"+ oneD.GetLength(0));
        Console.WriteLine("1D Rank:"+ oneD.Rank);

        Console.WriteLine("2D Length:"+ twoD.Length);
        Console.WriteLine("2D Length(0):"+ twoD.GetLength(0));
        Console.WriteLine("2D Length(0):"+ twoD.GetLength(1));
        Console.WriteLine("2D Rank:"+ twoD.Rank);
    }
}