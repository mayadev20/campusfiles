using System;

class Program {
    static void Main(string[] args) {

        int age=25;
        bool isStudent =true;

        //
        bool CanGetDiscount = age <30 && isStudent;
        Console.WriteLine("Can Get Discount? "+CanGetDiscount);

        bool CanEnterClub = age>=18 || isStudent;
        Console.WriteLine("Can Enter Club? "+CanEnterClub);

        bool isTeenager = age>=13 && age<=19;
        Console.WriteLine("Is Teenager? "+isTeenager);


    }

}