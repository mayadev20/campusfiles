// Write a C# console program using the do-while structure to do following requirements.
// a. Get the Student’s name as user inputs.
// b. If the provided student’s name is not equal to ‘END’ then ask user to enter days attend for the lectures in a month.
// c. Calculate the total hours as the total time the student be with the lectures. 
//      Assume lecture time duration is 3 hours per week.
// d. Display the Name and Total Hours. This process is repeated until the name read is equal to “END”.

using System;

public class totalhours{

    public static void Main(){

        string Name="";
        double hours,days;
        do{
            Console.Write("Enter Name: ");
            Name=Console.ReadLine();

            if (Name!="END"){
                Console.Write("Enter Attended Days: ");
                days=double.Parse(Console.ReadLine());
                hours=days*3;
            }
            else{
                break;
            }
            Console.WriteLine("Name : {0} \nTotal Hours : {1}\n",Name,hours);
        }while (Name!="END");

        

}}