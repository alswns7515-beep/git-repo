using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();  // 입력 받고 앞뒤 공백 제거

        if (string.IsNullOrEmpty(input))           // 입력이 공백뿐일 경우
        {
            Console.WriteLine(0);
        }
        else
        {
            string[] words = input.Split(' ');     // 공백 기준으로 단어 분리
            Console.WriteLine(words.Length);       // 단어 개수 출력
        }
    }
}

