import java.util.*;

public class CharConverter{
	public static void main(String[] args){
		Scanner sc= new Scanner(System.in);
		char selection;

		System.out.println("Please enter Character: ");
		selection = sc.next().charAt(0);

		if((selection>='A') && (selection<='Z') || (selection >='a') &&(selection<='z')){
			System.out.println("The ASCII value of '"+selection+"' is:" + (int)selection);
		}



	}
}
