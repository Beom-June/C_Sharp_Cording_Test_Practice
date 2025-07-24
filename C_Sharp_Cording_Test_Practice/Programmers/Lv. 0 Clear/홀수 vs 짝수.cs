using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 리스트 num_list가 주어집니다. 
 * 가장 첫 번째 원소를 1번 원소라고 할 때, 
 * 홀수 번째 원소들의 합과 짝수 번째 원소들의 합 중 큰 값을 
 * return 하도록 solution 함수를 완성해주세요. 
 * 두 값이 같을 경우 그 값을 return합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;
            int _evenSum = 0;
            int _oddSum = 0;

            for (int i = 0; i < num_list.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    _evenSum += num_list[i];
                }
                else 
                {
                    _oddSum += num_list[i];
                }
            }

            answer = Math.Max(_evenSum, _oddSum);
            return answer;
        }
    }
    class 홀수_vs_짝수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _num_list1 = { 4, 2, 6, 1, 7 };
            int[] _num_list2 = { -1, 2, 5, 6, 3 };

            Console.WriteLine(_solution.solution(_num_list1));
            Console.WriteLine(_solution.solution(_num_list2));
        }
    }
    */
}
