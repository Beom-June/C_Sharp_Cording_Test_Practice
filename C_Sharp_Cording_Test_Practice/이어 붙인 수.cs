using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수가 담긴 리스트 num_list가 주어집니다. 
 * num_list의 홀수만 순서대로 이어 붙인 수와 짝수만 
 * 순서대로 이어 붙인 수의 합을 return하도록 solution 함수를 완성해주세요.
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
                if (num_list[i] % 2 == 0)
                {
                    _evenSum = _evenSum * 10 + num_list[i];
                }
                else
                {
                    _oddSum = _oddSum * 10 + num_list[i];
                }
            }
            answer = _evenSum + _oddSum;

            return answer;
        }
    }
    class 이어_붙인_수
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
