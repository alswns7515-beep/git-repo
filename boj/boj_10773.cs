using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());      // 첫 줄 입력: 몇 개의 숫자를 입력할지
        Stack<int> stack = new Stack<int>();        // 스택 생성 (최근 입력을 저장할 곳)

        for (int i = 0; i < K; i++)                 // K번 반복
        {
            int num = int.Parse(Console.ReadLine()); // 한 줄씩 정수 입력

            if (num == 0)
            {
                stack.Pop(); // 0이면 최근 입력한 수를 제거
            }
            else
            {
                stack.Push(num); // 0이 아니면 스택에 추가
            }
        } // ← 여기에 빠졌던 닫는 괄호 추가됨 ✅

        int sum = 0;                                // 합계 변수
        foreach (int n in stack)
        {
            sum += n;                               // 스택에 남은 모든 수를 더함
        }

        Console.WriteLine(sum);                     // 결과 출력
    }
}
