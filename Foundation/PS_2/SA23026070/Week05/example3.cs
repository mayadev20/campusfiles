
using System;

public struct Employee{
    public string name;
    public int age;
}

public class EmpDetails
{
    public static void Main()
    {
        Employee emp01,emp02;

        emp01.name = "Smith";
        emp01.age = 20;

        emp02.name = "Lora";
        emp02.age = 25;

        Console.WriteLine ("Employee 01\'s Details: \n Name: {0} \n Age: {1}",emp01.name,emp01.age);
        Console.WriteLine ("Employee 02\'s Details: \n Name: {0} \n Age: {1}",emp02.name,emp02.age);
    }
}