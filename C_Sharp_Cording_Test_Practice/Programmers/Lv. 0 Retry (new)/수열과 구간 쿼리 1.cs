using System;

/* 정수 배열 arr와 2차원 정수 배열 queries이 주어집니다. 
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
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int s = queries[i, 0];
                int e = queries[i, 1];

                for (int j = s; j <= e; j++)
                {
                    arr[j]++;
                }
            }
            return arr;
        }
    }
    class 수열과_구간_쿼리_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 0, 1, 2, 3, 4 };
            int[,] _queries = { { 0, 1 }, { 1, 2 }, { 2, 3 } };

            foreach (var i in _solution.solution(_arr, _queries))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}