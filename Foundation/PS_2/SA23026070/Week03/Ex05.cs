using System;

class Incrementation {
    static void Main(){

        int a=12;
        int b=20;
        int c=5;
        int d=16;

        Console.WriteLine("Pre Incrementation = "+ ++a);
        

        Console.WriteLine("Post Incrementation = "+ b++);
        Console.WriteLine("Post Incrementation = "+ b);

        Console.WriteLine("Pre Decrementation = "+ --c);


        Console.WriteLine("Post Decrementation = "+ d--);
        Console.WriteLine("Post Decrementation = "+ d);
    }
}