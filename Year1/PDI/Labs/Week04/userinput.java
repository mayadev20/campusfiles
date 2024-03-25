import java.util.*;

public class userinput
{
    public static void main(String[] args)
{
    Scanner sc= new Scanner(System.in);
    String name;
    
    do{
    System.out.println("Enter your Name: ");
    name=sc.next();
    }while(name!="0");

}
}
