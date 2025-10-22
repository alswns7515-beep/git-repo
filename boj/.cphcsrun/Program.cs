using System;
using System.Text;

class Program
{
    static void Main()
    {
        int testcounts = int.Parse(Console.ReadLine());
        int[] que = new int[testcounts];
        int first = 0;
        int last = 0;

        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < testcounts ; i++)
        {

            string[] inputs = Console.ReadLine().Split();

            switch(inputs[0])
            {
                case "push" :
                que[last++] = int.Parse(inputs[1]);
                break;

                case "pop" :
                if(first == last)
                sb.AppendLine("-1");

                else
                sb.AppendLine(que[first++].ToString());
                break;

                case "size" :
                sb.AppendLine((last - first).ToString());
                break;

                case "empty" :
                if(first == last)
                sb.AppendLine("1");

                else
                sb.AppendLine("0");
                break;

                case "front" :
                if(first == last)
                sb.AppendLine("-1");
                
                else
                sb.AppendLine(que[first].ToString());
                break;

                case "back" :
                if(first == last)
                sb.AppendLine("-1");

                else
                sb.AppendLine(que[last-1].ToString());
                break;
                
            }
        }
        Console.WriteLine(sb.ToString());
    }
}
