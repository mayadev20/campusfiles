
using System;

enum Age {
        Kamal = 40,
        Sunil = 38,
        Piyal = 42
    }

public class HelloWorld
{
    public static void Main()
    {
        int ageKamal = (int) Age.Kamal;
        int ageSunil = (int) Age.Sunil;
        int agePiyal = (int) Age.Piyal;

        Console.WriteLine ("Ages are {0},{1},{2}", ageKamal,ageSunil,agePiyal);
    }
}