using System;
using System.Linq;
using System.Text;

class Program

{
    static void Main()
    {
        int testcase = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split();

        int[] Mnum = new int[testcase];

        for( int i = 0; i < testcase; i++)
        {
            Mnum[i] = int.Parse(inputs[i]);
        }
        int M = Mnum.Max();
        double[] Anum = new double[testcase];

        for( int j = 0 ; j < testcase; j++)
        {
            Anum[j] = (double)Mnum[j]/M * 100;
        }

        double avg = Anum.Average();

        Console.WriteLine(avg);
    }
}