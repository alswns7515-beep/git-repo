using System; // 콘솔 입출력(Console.WriteLine, ReadLine 등)을 사용하기 위해 필요

class Program
{
    static void Main()
    {
        string n = Console.ReadLine(); // 방 번호를 문자열 형태로 입력받음 (예: "9999")
        
        int[] count = new int[10];     // 0부터 9까지 각 숫자의 개수를 저장할 배열 생성 (처음엔 전부 0)

        // 방 번호의 각 문자를 하나씩 확인
        foreach (char c in n)
        {
            int num = c - '0';         // 문자 '0'~'9'를 실제 정수 0~9로 변환
            count[num]++;              // 해당 숫자의 개수를 1 증가시킴
        }

        // 6과 9는 서로 바꿔서 쓸 수 있으므로 둘을 합쳐서 세트 수를 다시 계산해야 함
        int sixNineTotal = count[6] + count[9];  // 6의 개수 + 9의 개수
        int sixNineSet = (sixNineTotal + 1) / 2; // 올림 계산: (합 + 1) / 2
        
        // 6과 9를 제외한 숫자들 중 가장 많이 필요한 개수를 찾음
        int maxCount = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i == 6 || i == 9) continue;  // 6과 9는 건너뜀
            if (count[i] > maxCount)         // 현재 숫자가 이전 최대보다 많다면
                maxCount = count[i];         // 최댓값 갱신
        }

        // 6/9 세트 수와 다른 숫자 최댓값 중 더 큰 값이 최종 세트 개수
        int answer = Math.Max(maxCount, sixNineSet);

        Console.WriteLine(answer); // 결과 출력
    }
}
