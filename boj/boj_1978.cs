using System;

class Program
{
    static void Main()
    {

    int N = int.Parse(Console.ReadLine());
    string[] nums = Console.ReadLine().Split();
    Array.Sort(nums);
    Array.Reverse(nums);
    int sums = 0;

    for ( int i = 0; i < N ; i++)
    {
        int levels = int.Parse(nums[i]);
        int divide = 0;

        for (int j = 1; j <= levels; j++)
        {
            if( levels % j == 0)
            {
                divide++;
            }
        }

        if (divide == 2)
        {
            sums++;
        }
    }
    Console.WriteLine(sums);
    }
}
