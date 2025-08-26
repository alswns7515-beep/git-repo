using System;
using System.Linq;

class Program

{
    static void Main()
    {
        int[] nums = new int[10];

        for( int i = 0; i < 10 ; i ++)
        {
            int N = int.Parse(Console.ReadLine());
            nums[i] = N % 42;
            
        }

        Array.Sort(nums);
        int sums = 1;

        for( int j = 0; j < 9 ; j++)
        {
            if( nums[j] != nums[j+1])
            {
                sums += 1;
            }
        }

        Console.WriteLine(sums);
    }
}