
using System;

public struct userdetails{
    public string f_name,m_name,l_name;
}

public class UserInputDetails
{
    public static void Main()
    {
        
        userdetails user01;
        Console.Write("Enter First Name : ");
        user01.f_name = Console.ReadLine();
        Console.Write("Enter Middle Name : ");
        user01.m_name = Console.ReadLine();
        Console.Write("Enter Sur Name : ");
        user01.l_name = Console.ReadLine();

        Console.WriteLine ("Full name is, {0} {1} {2}",user01.f_name,user01.m_name,user01.l_name);

    }
}