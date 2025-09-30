using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 점의 개수 입력
        int testCases = int.Parse(Console.ReadLine());
        
        // 점들을 저장할 리스트
        List<(int x, int y)> points = new List<(int, int)>();

        // N개의 점 입력받기
        for (int i = 0; i < testCases; i++)  // ← 세미콜론으로 수정
        {
            string[] inputs = Console.ReadLine().Split();
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            points.Add((x, y));
        }

        // 정렬: x 오름차순, x 같으면 y 오름차순
        var sortedPoints = points.OrderBy(p => p.x).ThenBy(p => p.y);

        // 결과 출력
        foreach (var p in sortedPoints)   // ← 변수 이름 맞춤
        {
            Console.WriteLine($"{p.x} {p.y}");
        }
    }
}
