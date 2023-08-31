using System;

class Increments {

    static void Main(string[] args){

        //Post Increment
        int a=10;

        Console.WriteLine(a);
        Console.WriteLine(a++);
        Console.WriteLine(a);

        Console.WriteLine();

        //Pre Increment
        int b=20;
        Console.WriteLine(b);
        Console.WriteLine(++b);
        Console.WriteLine(b);

        Console.WriteLine();

        //Post Decrement
        int c=15;
        Console.WriteLine(c);
        Console.WriteLine(c--);
        Console.WriteLine(c);

        Console.WriteLine();

        //Pre Decrement
        int d=12;
        Console.WriteLine(d);
        Console.WriteLine(--d);
        Console.WriteLine(d);

        Console.WriteLine();
    }
}