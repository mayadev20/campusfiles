using System;

public class Example{
    

    public static void Main(){
        char letter;
        Console.WriteLine("Enter the letter");
        letter = Convert.ToChar(Console.ReadLine());

        if (letter=='a' | letter=='e' | letter=='i' | letter=='o' | letter=='u'){
            Console.WriteLine(letter+" is a Vowel");
        }

    }
}