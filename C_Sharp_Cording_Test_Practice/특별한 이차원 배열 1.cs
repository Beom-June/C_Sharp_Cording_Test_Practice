using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        answer[i, j] = 1;
                    else
                        answer[i, j] = 0;
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

            int _n1 = 3, _n2 = 6, _n3 = 1;

            int[,] result1 = _solution.solution(_n1);
            PrintArray(result1);

            int[,] result2 = _solution.solution(_n2);
            PrintArray(result2);

            int[,] result3 = _solution.solution(_n3);
            PrintArray(result3);
        }

        static void PrintArray(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    */
}
