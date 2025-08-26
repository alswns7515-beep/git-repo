using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int [] nums = Array.ConvertAll(input, int.Parse);

        bool Asc = true;
        
        for (int i = 0 ; i < 8 ; i++)
        {
            if(nums[i] != i + 1)
            {
                Asc = false;
                break;
            }
        }

        bool Des = true;
        for (int i = 0 ; i < 8 ; i++)
        {
            if(nums[i] != 8 - i)
            {
                Des = false;
                break;
            }
        }

        if (Asc)
        {
            Console.WriteLine("ascending");
        }

        else if (Des)
        {
            Console.WriteLine("descending");
        }

        else
        {
            Console.WriteLine("mixed");
        }
        
    }
}
