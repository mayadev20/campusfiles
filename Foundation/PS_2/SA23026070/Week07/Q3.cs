// You are designing a login system. Write a C# program that prompts the user for a
// username and password. If the username is "admin" and the password is
// "password123," display "Login successful." Otherwise, display "Login failed.". Use
// Ternary Conditional Statements to manage the process.

using System;

public class loginpage {
    public static void Main (){

        string username,password,result;

        Console.Write("Enter Username: ");
        username = Console.ReadLine();
        Console.Write("Enter Password: ");
        password = Console.ReadLine();

        result = (username == "admin" & password == "password123") ? "Login successful" : "Login failed";
        Console.WriteLine(result);
    }
}
