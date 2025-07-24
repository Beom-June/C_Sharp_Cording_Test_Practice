using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 arr와 2차원 정수 배열 queries이 주어집니다. 
 * queries의 원소는 각각 하나의 query를 나타내며, [s, e, k] 꼴입니다.
 * 
 * 각 query마다 순서대로 s ≤ i ≤ e인 모든 i에 대해 k보다 크면서 가장 작은 arr[i]를 찾습니다.
 * 각 쿼리의 순서에 맞게 답을 저장한 배열을 반환하는 solution 함수를 완성해 주세요.
 * 단, 특정 쿼리의 답이 존재하지 않으면 -1을 저장합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
        {
            int[] answer = new int[queries.GetLength(0)];

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int _s = queries[i, 0];
                int _e = queries[i, 1];
                int _k = queries[i, 2];

                int _min = int.MaxValue;
                bool _found = false;

                for (int j = _s; j <= _e; j++)
                {
                    if (arr[j] > _k)
                    {
                        _min = Math.Min(_min, arr[j]);
                        _found = true;
                    }
                }

                answer[i] = _found ? _min : -1;
            }

            return answer;
        }
    }
    class 수열과_구간_쿼리_2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 0, 1, 2, 4, 3 };
            int[,] _queries = { { 0, 4, 2 }, { 0, 3, 2 }, { 0, 2, 2 } };

            foreach (var _print in _solution.solution(_arr, _queries))
            {
                Console.Write(_print + " ");    //  3, 4, -1
            }
            Console.WriteLine();
        }
    }
    */
}
