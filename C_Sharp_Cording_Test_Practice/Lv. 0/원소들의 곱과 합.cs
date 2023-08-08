using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수가 담긴 리스트 num_list가 주어질 때, 
 * 모든 원소들의 곱이 모든 원소들의 합의 제곱보다 작으면 1을 
 * 크면 0을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;

            int _totalMulti = 1;
            int _totalSum = 0;

            // 모든 원소의 곱
            for (int i = 0; i < num_list.Length; i++)
            {
                _totalMulti *= num_list[i];
            }

            // 합의 제곱
            for (int i = 0; i < num_list.Length; i++)
            {
                _totalSum += num_list[i];
            }
            _totalSum *= _totalSum;

            // 비교
            answer = (_totalMulti < _totalSum) ? 1 : 0;

            return answer;
        }
    }
    class 원소들의_곱과_합
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _num_list1 = { 3, 4, 5, 2, 1 };
            int[] _num_list2 = { 5, 7, 8, 3 };

            Console.WriteLine(_solution.solution(_num_list1));
            Console.WriteLine(_solution.solution(_num_list2));
        }
    }
    */
}
