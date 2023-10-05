// Create a C# program that simulates a simple calculator. Prompt the user to enter two
// numbers and an operator (+, -, *, /). Use a switch-case statement to perform the
// calculation and display the result.

using System;
public class calculator {
    public static void Main(){
        int num1,num2,result;
        char u_operator;

        Console.WriteLine("Enter Number 1");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number 2");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Operator");
        u_operator = char.Parse(Console.ReadLine());

        switch (u_operator){

            case '+':
                result = num1+num2;
                Console.WriteLine(result);
                break;
            case '-':
                result = num1-num2;
                Console.WriteLine(result);
                break;
            case '*':
                result = num1*num2;
                Console.WriteLine(result);
                break;
            case '/':
                result = num1/num2;
                Console.WriteLine(result);
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
    }

}