using System;

public class Question1 {

    public static void Main(){

        int n=15,y=0;
        
        while (y<50){
            double data=0;
            data = (n%18>0)? data=2.5 : data=3.5;
            y++;
            Console.WriteLine(data); //IF want
         }
    }
}

