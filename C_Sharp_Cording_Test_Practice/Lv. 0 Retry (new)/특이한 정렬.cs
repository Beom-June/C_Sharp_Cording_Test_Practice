using System;
using System.Linq;

/* Retry
 * 정수 n을 기준으로 n과 가까운 수부터 정렬하려고 합니다. 
 * 이때 n으로부터의 거리가 같다면 더 큰 수를 앞에 오도록 배치합니다. 
 * 
 * 정수가 담긴 배열 numlist와 정수 n이 주어질 때 numlist의 원소를 
 * n으로부터 가까운 순서대로 정렬한 배열을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] numlist, int n)
        {
            int[] answer = new int[numlist.Length];
            answer = numlist
            .OrderBy(x => Math.Abs(x - n))  // n으로부터의 절대 거리로 정렬
            .ThenByDescending(x => x)       // 거리 같을 경우 큰 수를 먼저 배치
            .ToArray();
            return answer;
        }
    }
    class 특이한_정렬
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numlist01 = { 1, 2, 3, 4, 5, 6 };
            int[] _numlist02 = { 10000, 20, 36, 47, 40, 6, 10, 7000 };

            // 4, 5, 3, 6, 2, 1
            foreach (var i in _solution.solution(_numlist01, 4))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 36, 40, 20, 47, 10, 6, 7000, 10000
            foreach (var i in _solution.solution(_numlist02, 30))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}