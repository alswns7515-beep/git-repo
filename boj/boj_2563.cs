using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        bool[,] paper = new bool[100, 100];

        for (int k = 0; k < n; k++)
        {
            string[] input = Console.ReadLine()!.Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            for (int i = x; i < x + 10; i++)
            {
                for (int j = y; j < y + 10; j++)
                {
                    paper[i, j] = true;
                }
            }
        }

        int area = 0;
        foreach (bool cell in paper)
        {
            if (cell) area++;
        }

        Console.WriteLine(area);
    }
}
