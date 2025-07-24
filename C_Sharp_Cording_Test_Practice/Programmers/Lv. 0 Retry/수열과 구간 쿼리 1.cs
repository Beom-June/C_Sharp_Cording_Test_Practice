using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 arr와 2차원 정수 배열 queries이 주어집니다. 
 * queries의 원소는 각각 하나의 query를 나타내며, [s, e] 꼴입니다.
 * 
 * 각 query마다 순서대로 s ≤ i ≤ e인 모든 i에 대해 arr[i]에 1을 더합니다.
 * 
 * 위 규칙에 따라 queries를 처리한 이후의 arr를 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
        {
            int[] answer = new int[arr.Length];
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int _start = queries[i, 0];
                int _end = queries[i, 1];

                for (int j = _start; j <= _end; j++)
                {
                    arr[j] += 1;  // 각 구간 내의 원소에 1을 더함
                }
            }
            Array.Copy(arr, answer, arr.Length);  // 결과를 answer 배열로 복사
            return answer;
        }
    }
    class 수열과_구간_쿼리_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 0, 1, 2, 3, 4 };
            int[,] _queries = { { 0, 1 }, { 1, 2 }, { 2, 3 } };

            int[] result = _solution.solution(_arr, _queries);
            Console.WriteLine(string.Join(" ", result));
        }
    }
    */
}
