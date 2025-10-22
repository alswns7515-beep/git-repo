using System;
using System.Linq;

class Program

{
    static void Main()
    {
        while(true)
        {
            string input = Console.ReadLine();
            string IsValid = new string(input.Reverse().ToArray());

            if(input == "0")
            {
                break;
            }

            if( IsValid == input)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}