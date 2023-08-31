using System;

public class PowerBank{
    
        public float MaH;
        public string USBType, Brand;

        public PowerBank(float m, string u, string b){
            this.MaH = m;
            this.USBType = u;
            this.Brand = b;
        }

        public double getMiliAmp(double mval){
            double result;
            result = Math.Pow(MaH,mval);
            return result;
        }


}

public class NewPowerBank{
    public static void Main(){
        Console.Write("Enter a Value to MaH: ");
        float mah = float.Parse(Console.ReadLine());

        Console.Write("Enter Usb Type: ");
        string usb = Console.ReadLine();

        Console.Write("Enter Brand: ");
        string brand = Console.ReadLine();

        PowerBank pb = new PowerBank(mah,usb,brand);

        Console.WriteLine("Answer is = "+ pb.getMiliAmp(1.2));
        Console.WriteLine("Usb Type = "+pb.USBType);
        Console.WriteLine("Brand = "+pb.Brand);

    }
}