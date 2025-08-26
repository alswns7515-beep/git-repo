using System;

class Program

{
    static void Main()
    {

        string letter = Console.ReadLine();

        int[] N = new int[26];

        for( int i = 0; i < 26 ; i++)
        {
            N[i] = -1;
        }

        for (int i = 0; i < letter.Length; i++)
        {
            int index = letter[i] - 'a';

            if(N[index] == -1)
            {
                N[index] = i;
            }
        }

        Console.WriteLine(string.Join(" ", N));

    }
}