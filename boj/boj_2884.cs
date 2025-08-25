using System;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < T ; i++)
        {
            string[] input = Console.ReadLine().Split();
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);
            int N = int.Parse(input[2]);

            int floors = N % H;
            int rooms = N / H + 1;

            if(floors == 0)
            {
                floors = H;
                rooms = N / H;
            }
            
            Console.WriteLine($"{floors}{rooms:D2}");
        }
    }
}
