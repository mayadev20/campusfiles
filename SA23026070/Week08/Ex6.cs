// Write a program to print odd numbers in between 1-100. Once the program displaying
// the outputs,
// if 21 and 59 found, continue the program.
// if 83 found, break the program

using System;

public class oddNum{

    public static void Main(){

        int num=1;

        while (num<=100){
            Console.WriteLine(num);
            num=num+2;

            if (num==21 || num==59){
                continue;
            }
            else if (num==83){
                break;
            }
        }
    }
}