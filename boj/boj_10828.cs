using System;
using System.Text;
class Program

{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] stack = new int[N];
        int B = 0;

        StringBuilder sb  = new StringBuilder();

        for(int i = 0 ; i < N ; i++)
        {
            string[] inputs = Console.ReadLine().Split();

            switch(inputs[0])
            {
                case "push" :
                stack[B++] = int.Parse(inputs[1]);
                break;

                case "pop" :
                if(B == 0)
                {
                    sb.AppendLine("-1");
                }

                else
                {
                    sb.AppendLine(stack[--B].ToString());
                }
                break;

                case "size" :
                sb.AppendLine(B.ToString());
                break;

                case "empty" :
                if(B == 0)
                sb.AppendLine("1");
                
                else
                sb.AppendLine("0");
                break;

                case "top" :
                if(B == 0)
                {
                    sb.AppendLine("-1");
                }

                else
                sb.AppendLine(stack[B-1].ToString());
                break;
            }
        }
        Console.WriteLine(sb.ToString());
    }
}