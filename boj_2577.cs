using System;

class Program
{
    static void Main()
    {

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        int multiple = A * B * C;

        int[] count = new int[10];

        string st = multiple.ToString();
        
        foreach(char c in st)
        {
            int digit = c - '0';
            count[digit]++;
        }

        for( int i = 0; i < 10 ; i ++)
        {
            Console.WriteLine(count[i]);
        }
        
        



    }
}

