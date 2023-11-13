
using System;

enum Seasons {
        Spring,
        Summer,
        Fall,
        Winter
    }

public class SeasonsPreview
{
    public static void Main()
    {
        Seasons Spring = Seasons.Spring;
        Seasons Summer = Seasons.Summer;
        Seasons Fall = Seasons.Fall;
        Seasons Winter = Seasons.Winter;

        Console.WriteLine ("Seasons are {0} , {1} , {2} , {3}", Spring,Summer,Fall,Winter);
    }
}
