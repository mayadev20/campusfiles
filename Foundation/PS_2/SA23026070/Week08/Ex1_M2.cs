// Print the following number pattern using While loop, Do-While loop and For loop.
// 3 7 11 15 19 
using System;

public class numpattern{

    public static void Main(){

        int num=3;
        do{
            Console.Write(num+" ");
            num=num+4;
        }while(num<20);
        
}}