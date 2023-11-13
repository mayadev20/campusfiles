using System;

class TaxCal 
{
    public static void Main()
    {
        double purchase,tax,cost;
        
        Console.WriteLine("Enter Purchase Value:");
        purchase=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Tax Value:");
        tax=double.Parse(Console.ReadLine());

        cost = (purchase*tax)+purchase;

        Console.WriteLine("Total Cost : "+cost);

    }

}