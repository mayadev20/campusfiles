using System;

class Summation
{
    public static void Main()
    {
        //initiate variables
        int no1,no2,sum;

    /* //assigning values
        no1=5;
        no2=8;

        //calcuating
        sum = no1+no2; */

        Console.WriteLine("Enter No 1");
        no1= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter No 2");
        no2= int.Parse(Console.ReadLine());

        sum=no1+no2;

        //Output
        Console.WriteLine(sum);

    }


}