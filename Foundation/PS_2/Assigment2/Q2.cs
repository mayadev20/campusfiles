using System;

public class Question2 {

    public static void Main(){

    char checkagain;
    
    do{
        int total=0,days,c=1,distance;
        string type;
        Console.Write("Enter the vehicle type : ");
        type=Console.ReadLine();
        Console.Write("Enter the total number of days traveled : ");
        days=int.Parse(Console.ReadLine());
        while (c<=days){
            Console.Write("Distance for day {0}: ",c);
            distance = int.Parse(Console.ReadLine());
            total = total+distance;
            c++;
        }
        Console.WriteLine("\nTotal distance (km) : {0}",total);
        if (total>2000){
            Console.WriteLine("The vehicle Eligible to send for service.");
        }
        else {
            Console.WriteLine("The vehicle Not eligible to send for service.");
        }
      
        Console.Write("\nDo you want to check more (Y/N) : ");
        checkagain = char.Parse(Console.ReadLine());

    }while(checkagain=='Y');

    }
}
