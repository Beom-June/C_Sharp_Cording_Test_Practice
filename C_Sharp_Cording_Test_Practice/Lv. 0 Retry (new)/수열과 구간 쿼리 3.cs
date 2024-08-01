using System;

/* Retry
 * 정수 배열 arr와 2차원 정수 배열 queries이 주어집니다. 
 * queries의 원소는 각각 하나의 query를 나타내며, [i, j] 꼴입니다.
 * 
 * 각 query마다 순서대로 arr[i]의 값과 arr[j]의 값을 서로 바꿉니다.
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
            // queries에 있는 쿼리들을 순차적으로 처리
            for (int k = 0; k < queries.GetLength(0); k++)
            {
                int i = queries[k, 0];
                int j = queries[k, 1];

                // arr[i]와 arr[j]의 값을 서로 교환
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            return arr;
        }
    }
    class 수열과_구간_쿼리_3
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 0, 1, 2, 3, 4 };
            int[,] _queries = { { 0, 3 }, { 1, 2 }, { 1, 4 } };

            foreach (var i in _solution.solution(_arr, _queries))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}