using System;

/* 점 네 개의 좌표를 담은 이차원 배열  dots가 다음과 같이 매개변수로 주어집니다.
 * 
 * [[[ x1, y1], [x2, y2], [x3, y3], [x4, y4]]
 * 주어진 네 개의 점을 두 개씩 이었을 때, 두 직선이 평행이 되는 경우가 
 * 있으면 1을 없으면 0을 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[,] dots)
        {
            int answer = 0;

            // dots[0, 0], dots[0, 1] → (x1, y1)
            // dots[1, 0], dots[1, 1] → (x2, y2)
            // dots[2, 0], dots[2, 1] → (x3, y3)
            // dots[3, 0], dots[3, 1] → (x4, y4)

            // 점의 인덱스를 기준으로 3쌍의 선을 만든다:
            // (0,1) vs (2,3), (0,2) vs (1,3), (0,3) vs (1,2)

            // 첫 번째: 점 0-1 과 점 2-3의 기울기 비교
            if ((dots[1, 1] - dots[0, 1]) * (dots[3, 0] - dots[2, 0])
                == (dots[3, 1] - dots[2, 1]) * (dots[1, 0] - dots[0, 0]))
            {
                return 1; // 기울기가 같으면 평행
            }

            // 두 번째: 점 0-2 과 점 1-3의 기울기 비교
            if ((dots[2, 1] - dots[0, 1]) * (dots[3, 0] - dots[1, 0])
                == (dots[3, 1] - dots[1, 1]) * (dots[2, 0] - dots[0, 0]))
            {
                return 1; // 기울기가 같으면 평행
            }

            // 세 번째: 점 0-3 과 점 1-2의 기울기 비교
            if ((dots[3, 1] - dots[0, 1]) * (dots[2, 0] - dots[1, 0])
                == (dots[2, 1] - dots[1, 1]) * (dots[3, 0] - dots[0, 0]))
            {
                return 1; // 기울기가 같으면 평행
            }

            // 위 세 쌍 모두 평행하지 않으면 0
            return answer;
        }
    }
    internal class 평행
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _dots01 = { { 1, 4 }, { 9, 2 }, { 3, 8 }, { 11, 6 } };
            int[,] _dots02 = { { 3, 5 }, { 4, 1 }, { 2, 4 }, { 5, 10 } };

            Console.WriteLine(_solution.solution(_dots01)); // 1
            Console.WriteLine(_solution.solution(_dots02)); // 0
        }
    }
    */
}