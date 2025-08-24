using System;

class Program
{
    static void Main()
    {
        string[] A = Console.ReadLine().Split();
        int a= int.Parse(A[0]);
        int b= int.Parse(A[1]);
        int c = 60;
        
        if (b < 45 )
        {
            a = a-1;
            if( a < 0) a = 23;
            c = b-45+c;
        }

        else
        {
            c = b-45;
        }

        Console.Write(a + " " + c);
        
    }
}
