
using System;

enum Color {
        Red,
        Yellow,
        Green
    }

public class HelloWorld
{
    public static void Main()
    {
        Color colorRed = Color.Red;
        Color colorYellow = Color.Yellow;
        Color colorGreen = Color.Green;
        Console.WriteLine ("Traffic Light System Colors Are {0} , {1} , {2}", colorRed,colorYellow,colorGreen);
    }
}