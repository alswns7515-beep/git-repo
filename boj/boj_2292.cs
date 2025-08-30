using System;

class Program

{
    static void Main()
    {
        int testcase = int.Parse(Console.ReadLine());
        
        for( int i = 0 ; i < testcase ; i++)
        {
            char leftside = '(';
            char rightside = ')';
            string PS = Console.ReadLine();
            int count = 0;
            bool IsValid = true;

            foreach(char c in PS)
            {
                if( c == leftside)
                {
                    count++;
                }
                else if ( c == rightside)
                {
                    count--;
                }
                
                if( count < 0)
                {
                    IsValid = false;
                    break;
                }
            }
            
            if(count != 0)
            {
                IsValid = false;
            }

            Console.WriteLine(IsValid ? "YES" : "NO");
            
        }
    }
}
