// Create a grading system program that takes a student's score as input and assigns a
// grade (A, B, C, D, or F) using nested if-else statements. Grading listed in below.
// Grade Marks Range
// A 75-100   B 60-74     C 45-59    D 30-44    F Below 44

using System;

public class grade{
    public static void Main(){
        int marks;
        Console.Write("Enter Marks: ");
        marks = int.Parse(Console.ReadLine());

        if (marks<=100 && marks>=75){
            Console.WriteLine("Grade A");
        }
        else if (marks<=74 && marks>=60){
            Console.WriteLine("Grade B");
        }
        else if (marks<=59 && marks>=45){
            Console.WriteLine("Grade C");
        }
        else if (marks<=44 && marks>=30){
            Console.WriteLine("Grade D");
        }
        else {
            Console.WriteLine("Grade F");
    }
}}