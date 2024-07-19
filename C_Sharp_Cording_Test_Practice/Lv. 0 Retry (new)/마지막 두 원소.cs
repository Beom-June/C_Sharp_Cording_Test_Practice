using System;
using System.Collections.Generic;

/* Retry
 * 정수 리스트 num_list가 주어질 때, 
 * 마지막 원소가 그전 원소보다 크면 마지막 원소에서 그전 원소를 뺀 값을 
 * 마지막 원소가 그전 원소보다 크지 않다면 마지막 원소를 두 배한 값을 추가하여 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            List<int> answer = new List<int>(num_list);

            int _last = num_list[num_list.Length - 1];
            int _lastBefore = num_list[num_list.Length - 2];

            if (_last > _lastBefore)
            {
                answer.Add(_last - _lastBefore);
            }
            else
            {
                answer.Add(_last * 2);
            }

            return answer.ToArray();
        }
    }
    class 마지막_두_원소
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numList01 = { 2, 1, 6 };
            int[] _numList02 = { 5, 2, 1, 7, 5, 10 };

            foreach (var item in _solution.solution(_numList01))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in _solution.solution(_numList02))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    */
}