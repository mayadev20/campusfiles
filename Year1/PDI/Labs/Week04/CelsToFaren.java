import java.util.*;

public class CelsToFaren
{
	public static void main(String[] args)
	{
		Scanner sc = new Scanner(System.in);
		double cels,faren;
		char selection;

		System.out.println("Which temperature scale are you converting from?");
		System.out.println("\t (C)elsius");
		System.out.println("\t (F)ahrenheit");
		selection = sc.next().charAt(0);
        do{

		if ((selection=='C') || (selection=='c')){
			System.out.println("Enter Celsius value: ");
			cels = sc.nextDouble();
			faren = cels*(9.0/5.0)+32;
			System.out.println(cels+ "C ="+faren+"F");
		}
		else if ((selection=='F') || (selection=='f')){
			System.out.println("Enter Fahrenheit value: ");
			faren = sc.nextDouble();
			cels = (faren-32)*(5.0/9.0);
			System.out.println(faren+ "F ="+cels+"C");
		}
		else{
			System.out.println("Invalid Character");
		}
        System.out.println("Which temperature scale are you converting from?");

            System.out.println("\t (C)elsius");
            System.out.println("\t (F)ahrenheit");
            selection = sc.next().charAt(0);

    }while((selection!='c') || (selection!='C') || (selection!='f') || (selection!='F'));
		

	}
}

//Working	
