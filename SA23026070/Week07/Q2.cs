using System;

class oddeven {

    public static void Main (){
        int num;
        string result;

        Console.WriteLine("Input a Number");
        num = int.Parse(Console.ReadLine());

        result = (num%2==0) ? "Number is Even" : "Number is Odd";
        Console.WriteLine(result);
    }
}