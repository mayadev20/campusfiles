// Write a C# program that takes a month (as an integer) as input and displays the
// corresponding name of the month. If the input is not a valid month (1-12), display an
// error message. Use Ternary Conditional Statements to manage the process

using System;

public class month {
    public static void Main(){
        int ui;
        string jan="January",feb="February",mar="March",apr="April",may="May",june="June",july="July";
        string aug="August",sep="September",oct="October",nov="November",dec="December",result;

        Console.Write("Enter Month: ");
        ui = int.Parse(Console.ReadLine());

        result = (ui==1)? jan : (ui==2)? feb : (ui==3)? mar : (ui==4)? apr : (ui==5)? may : (ui==6)? june : (ui==7)? july : (ui==8)? aug : (ui==9)? sep : (ui==10)? oct : (ui==11)? nov : (ui==12)? dec : "Incorrect Input";
        Console.WriteLine(result);

    }


}