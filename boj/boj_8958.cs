using System;

class Program
{
    static void Main()
    {
        int test = int.Parse(Console.ReadLine());

        for( int i = 0; i < test; i++)
        {   
            
            string input = Console.ReadLine();
            int continous = 0;
            int sums = 0;

            foreach(char c in input)
            {
                if (c == 'O')
                {
                    continous += 1;
                    sums += continous;
                }

                else
                {
                    continous = 0;
                }
            }
            Console.WriteLine(sums);
        }
    }
}
