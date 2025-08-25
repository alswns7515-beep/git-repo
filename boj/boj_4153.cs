using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while(true)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int A = input[0];
            int B = input[1];
            int C = input[2];

            if (A == 0 && B == 0 && C ==0 )
            {
                break;
            }

            Array.Sort(input);

            A = input[0];
            B = input[1];
            C = input[2];

            if (A*A + B*B == C*C)
            {
                Console.WriteLine("right");
            }

            else
            {
                Console.WriteLine("wrong");
            }


        }
    }


}

