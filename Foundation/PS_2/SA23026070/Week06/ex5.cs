// Write a C# program to verify the average of 3 student’s marks is exceed 50. Then
// prompt the message as “Average is grater than or equal to 50”. If not, prompt “Average
// is NOT grater than 50”.

using System;

public class Average{
    public static void Main(){
        float avg,stu1marks,stu2marks,stu3marks;
        Console.Write("Enter Student 1 Marks: ");
        stu1marks = float.Parse(Console.ReadLine());

        Console.Write("Enter Student 2 Marks: ");
        stu2marks = float.Parse(Console.ReadLine());

        Console.Write("Enter Student 3 Marks: ");
        stu3marks = float.Parse(Console.ReadLine());

        avg=(stu1marks+stu2marks+stu3marks)/3;

        if (avg>=50){
            Console.WriteLine("Average is greater than or equal to 50");
        }
        else{
            Console.WriteLine("Average is NOT greater than 50");
        }
    }
}