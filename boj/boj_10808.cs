using System;
using System.Text;
class Program

{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] alphabet = new int[26];
        StringBuilder sb = new StringBuilder();

        foreach(char c in input)
        {
            int index = c - 'a';
            alphabet[index]++;
        }

        for( int i = 0 ; i < 26; i++)
        {
            sb.Append(alphabet[i] + " ");
        }

        Console.Write(sb.ToString());
    }
}