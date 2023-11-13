// You are building a simple menu system for a restaurant application. Write code in C#
// that takes an order number as input (1-5) and uses a switch-case statement to display
// the corresponding item from the menu.
// Code Menu
// 1 Sri Lankan Special
// 2 Fried Rice
// 3 Noodles
// 4 Pasta
// 5 Koththu
// Any other input “Wrong Code input”

using System;
public class ordermenu {
    public static void Main(){
        int orderno;

        Console.WriteLine("Enter Order Number");
        orderno = int.Parse(Console.ReadLine());

        switch (orderno){

            case 1:
                Console.WriteLine("Sri Lankan Special");
                break;
            case 2:
                Console.WriteLine("Fried Rice");
                break;
            case 3:
                Console.WriteLine("Noodles");
                break;
            case 4:
                Console.WriteLine("Pasta");
                break;
            case 5:
                Console.WriteLine("Koththu");
                break;
            default:
                Console.WriteLine("Wrong Code input");
                break;
        }
    }

}