using System;

/* 정수 n이 매개변수로 주어질 때, 다음과 같은 n × n 크기의 
 * 이차원 배열 arr를 return 하는 solution 함수를 작성해 주세요.
 * 
 * arr[i][j] (0 ≤ i, j < n)의 값은 i = j라면 1, 아니라면 0입니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        answer[i, j] = 1;
                    }
                    else
                    {
                        answer[i, j] = 0;
                    }
                }
            }
            return answer;
        }
    }
    class 특별한_이차원_배열_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            foreach (var i in _solution.solution(3))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (var i in _solution.solution(6))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (var i in _solution.solution(1))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
