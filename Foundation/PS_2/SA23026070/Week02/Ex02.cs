using System;

class Product 
{
    public static void Main()
    {
        int no1,no2,product;

        Console.WriteLine("Enter No 1");
        no1= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter No 2");
        no2= int.Parse(Console.ReadLine());

        product=no1*no2;

        Console.WriteLine("Output is "+product);

    }

}