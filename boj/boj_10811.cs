using System;

class Program

{
    static void Main()
    {

    string[] input = Console.ReadLine().Split();

    int N = int.Parse(input[0]);
    int M = int.Parse(input[1]);

    int[] X = new int[N+1];

    for( int i = 0; i < N+1 ; i++)
    {
        X[i] = i;
    }

    for( int j = 0 ; j < M; j++)
    {
        string[] nums = Console.ReadLine().Split();
        int Q = int.Parse(nums[0]);
        int W = int.Parse(nums[1]);

        Array.Reverse(X,Q , W - Q+1);
    }

    Console.WriteLine(string.Join(" ",X.Skip(1)));

    }
}