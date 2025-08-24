using System;

class Program
{
    static void Main()
    {
        // 첫 번째 입력: 정수 A
        int A = int.Parse(Console.ReadLine());
        // 두 번째 입력: 정수 B
        int B = int.Parse(Console.ReadLine());
        // 세 번째 입력: 정수 C
        int C = int.Parse(Console.ReadLine());

        // 첫 번째 계산: A + B - C
        Console.WriteLine(A + B - C);

        // 두 번째 계산: (A와 B를 이어붙인 값) - C
        Console.WriteLine(int.Parse(A.ToString() + B.ToString()) - C);
    }
}
