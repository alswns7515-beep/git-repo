using System;

class Program

{
    static void Main()
    {

    int testcase = int.Parse(Console.ReadLine());
    string[] input = Console.ReadLine().Split();

    int V = int.Parse(Console.ReadLine());
    int sums = 0;

    for ( int i = 0 ; i < testcase ; i++)
    {
        int nums = int.Parse(input[i]);

        if(nums == V)
        {
            sums++;
        }

    }

    Console.Write(sums);

    }
}