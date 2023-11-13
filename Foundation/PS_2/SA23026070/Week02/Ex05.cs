using System;

class TemperatureConvert 
{
    public static void Main()
    {
        float temp_c,temp_f;

        Console.WriteLine("Enter Celsius Temperature");
        temp_c=float.Parse(Console.ReadLine());
        
        temp_f= (temp_c* 9/5) + 32;

        Console.WriteLine("Temperature in Fahrenheit : "+temp_f);

    }

}