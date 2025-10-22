using System;
using System.Text;
using System.Linq;

class Program

{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] arr = new string[N];
        StringBuilder sb = new StringBuilder();


        for(int i = 0; i < N ; i++)
        {
            arr[i] = Console.ReadLine();
        }

        foreach(string s in arr)
        {
            sb.Append(s);
        }

        Array.Sort(arr);

        Console.WriteLine(sb.ToString());


    }
}