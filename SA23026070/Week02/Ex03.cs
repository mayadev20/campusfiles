using System;

class Product 
{
    public static void Main()
    {
        int no1,no2,quotient;

        Console.WriteLine("Enter No 1");
        no1= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter No 2");
        no2= int.Parse(Console.ReadLine());

        quotient=no1/no2;

        Console.WriteLine("Output is "+quotient);

    }

}