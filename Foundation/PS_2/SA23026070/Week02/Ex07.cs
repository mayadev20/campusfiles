using System;

class AreaCircle 
{
    public static void Main()
    {
        double radius,area;
        double pi=3.14159;

        Console.WriteLine("Enter Radius");
        radius=double.Parse(Console.ReadLine());

        area=pi*radius*radius;
        
        Console.WriteLine("Area of the Circle : "+area);

    }

}