
using System;

enum P_count {
        Sunday = 2500,
        Saturday = 2100,
        Friday = 2350
    }

public class CovidPatientCount
{
    public static void Main()
    {
        int Sun_count= (int) P_count.Sunday;
        int Sat_count= (int) P_count.Saturday;
        int Fri_count= (int) P_count.Friday;
        
        Console.WriteLine ("Count of Covid19 Patents in Last 3 days\n Sunday: {0}\n Saturday: {1}\n Friday: {2}",Sun_count,Sat_count,Fri_count);
    }
}
