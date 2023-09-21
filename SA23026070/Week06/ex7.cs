// Following table shows the Covid 19 patients in last 3 days.
// Day & Patient Count = Sunday 250  ||  Saturday 210  ||  Friday 235

// Calculate the Summation of these patient counts and 
// if it is grater than or equals to 500, prompt a message as “Danger - Red”. 
// If it in between 250-500, prompt a message as “Average- Orange”. 
// If it below than 250, prompt the message as “Low Danger - Yellow”.

using System;
public class covid19{
    public static void Main(){
        int fri=235, sat=210, sun=250, total;

        total = (fri+sat+sun);
        if (total>=500){
            Console.WriteLine("Danger - Red");
        }
        else if (total<500 & total>250){
            Console.WriteLine("Average- Orange");
        }
        else {
            Console.WriteLine("Low Danger - Yellow");
        }
    }
}