// Develop a C# Console application that accept 7 daily temperatures into Array in a
// week and calculate the average temperature per week. 

using System;

public class TempArray {

    public static void Main(){
        double[] temps = new double[7] ;
        double total=0,avg;

        for (int i=0; i<7; i++){
            Console.Write("Enter Temperature: ");
            temps[i]=int.Parse(Console.ReadLine());
            total=total+temps[i];
        }
        avg=total/7;

        Console.WriteLine("Average temperature per week: "+avg);

        
    }
}