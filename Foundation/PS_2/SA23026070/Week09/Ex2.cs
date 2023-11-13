// Develop a C# program to store 5 friend names and show them as Friend List at
// the screen. 

using System;

public class NameArray {

    public static void Main(){
        //string[] names = new string[5] {"John","Peter","Herath","Kamal","Ramal"};
        string[] names = new string[5];
        

        for (int i=0; i<5; i++){
            Console.Write("Enter Name: ");
            names[i]=Console.ReadLine();
        }

        foreach (string k in names){
            Console.Write(k+" ");
        }
    }
}