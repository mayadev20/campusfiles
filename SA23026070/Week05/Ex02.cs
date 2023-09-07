
using System;

enum GM_count {
        USA = 39,
        China = 38,
        Japan = 27
    }

public class GoldMetalCount
{
    public static void Main()
    {
        
        int GM_USA = (int) GM_count.USA;
        int GM_CHINA = (int) GM_count.China;
        int GM_JAPAN = (int) GM_count.Japan;
        Console.WriteLine ("Gold Medal Counts\n USA: {0}\n China: {1}\n Japan: {2}",GM_USA,GM_CHINA,GM_JAPAN);
    }
}
