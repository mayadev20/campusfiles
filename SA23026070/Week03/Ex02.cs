using System;

class Program {
    static void Main(string[] args) {
        bool x = true;
        bool y = false;

        // Logical AND

        bool resultAND = x && y;
        Console.WriteLine("x && y = "+resultAND);

        // Logical OR
        bool resultOR= x || y;
        Console.WriteLine("x || y= "+resultOR);

        //Logical NOT
        bool resultNOTX = !x;
        Console.WriteLine("NOT x = "+resultNOTX);

       bool resultNOTY = !y;
       Console.WriteLine("NOT y = "+resultNOTY);
    }
}