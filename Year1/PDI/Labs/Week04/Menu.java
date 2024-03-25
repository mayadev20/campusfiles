import java.util.*;
public class Menu
{
	public static void main(String[] args)
	{
		Scanner sc = new Scanner(System.in);
		int choice,numOne,numTwo,answer;

		System.out.println("Welcome to Programming Design and Implimentation, Workshop 3");
		System.out.println("What would you like to do?");
		System.out.println("\t> 1. Sum of 2 Integers");
		System.out.println("\t> 2. Product of 2 Integers");
		System.out.println("\t> 3. Check if 2 Integers are Divisible");
		System.out.println("\t> 0. Exit");
		choice = sc.nextInt();
    do{
        if (choice==1){
				System.out.print("Enter first number: ");
				numOne = sc.nextInt();
				System.out.print("Enter second number: ");
				numTwo = sc.nextInt();
				answer = numOne + numTwo;
				System.out.println("The sum is " + answer);
			break;
    }
		else if (choice==2){
				System.out.print("Enter first number: ");
				numOne = sc.nextInt();
				System.out.print("Enter second number: ");
				numTwo = sc.nextInt();
				answer = numOne * numTwo;
				System.out.println("The product is " + answer);
			break;
    }
		else if (choice==3){
				System.out.print("Enter first number: ");
				numOne = sc.nextInt();
				System.out.print("Enter second number: ");
				numTwo = sc.nextInt();
				if (numTwo != 0)
				{
					answer = numOne % numTwo;
					if (answer == 0)
					{
						System.out.println("The numbers are divisible.");
					}
					else
					{
						System.out.println("The numbers are not divisible.");
					}
				}
            break;
        }
			
        else {
			System.out.println("Error: incorrect value input to program.");
			}
	
	}while(choice!=0);
        sc.close();
}

