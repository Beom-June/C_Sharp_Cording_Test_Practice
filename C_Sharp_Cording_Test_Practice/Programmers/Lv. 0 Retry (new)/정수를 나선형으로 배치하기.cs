using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 양의 정수 n이 매개변수로 주어집니다. 
 * n × n 배열에 1부터 n2 까지 정수를 인덱스 [0][0]부터 
 * 시계방향 나선형으로 배치한 이차원 배열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[n, n];

            // 오른쪽, 아래, 왼쪽, 위
            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { 1, 0, -1, 0 };

            int x = 0, y = 0, dir = 0;
            for (int num = 1; num <= n * n; num++)
            {
                answer[x, y] = num;

                //  다음 이동 위치 계산
                int nx = x + dx[dir];
                int ny = y + dy[dir];

                // 경계를 벗어나거나 이미 숫자가 채워진 경우 → 방향 전환
                if (nx < 0 || nx >= n || ny < 0 || ny >= n || answer[nx, ny] != 0)
                {
                    dir = (dir + 1) % 4;    // 방향 전환 (시계방향)
                    nx = x + dx[dir];
                    ny = y + dy[dir];
                }
                // 다음 위치로 이동
                x = nx;
                y = ny;
            }
            return answer;
        }
    }

    class 정수를_나선형으로_배치하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] result1 = _solution.solution(4);
            Console.WriteLine("4x4 배열:");
            for (int i = 0; i < result1.GetLength(0); i++)
            {
                for (int j = 0; j < result1.GetLength(1); j++)
                {
                    Console.Write($"{result1[i, j],3} ");
                }
                Console.WriteLine();
            }

            int[,] result2 = _solution.solution(5);
            Console.WriteLine("\n5x5 배열:");
            for (int i = 0; i < result2.GetLength(0); i++)
            {
                for (int j = 0; j < result2.GetLength(1); j++)
                {
                    Console.Write($"{result2[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
    */
}