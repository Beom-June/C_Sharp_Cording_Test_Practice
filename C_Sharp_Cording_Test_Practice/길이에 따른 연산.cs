using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수가 담긴 리스트 num_list가 주어질 때,
 * 리스트의 길이가 11 이상이면 리스트에 있는 모든 원소의 합을 10 이하이면 
 * 모든 원소의 곱을 return하도록 solution 함수를 완성해주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;
            if (num_list.Length >= 11)
            {
                foreach (int _num in num_list)
                {
                    answer += _num;
                }
            }
            else
            {
                answer = 1;
                foreach (int _num in num_list)
                {
                    answer *= _num;
                }
            }
            return answer;
        }
    }
    class 길이에_따른_연산
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _num_List1 = { 3, 4, 5, 2, 5, 4, 6, 7, 3, 7, 2, 2, 1 };
            int[] _num_List2 = { 2, 3, 4, 5 };

            Console.WriteLine(_solution.solution(_num_List1));
            Console.WriteLine(_solution.solution(_num_List2));
        }
    }
    */
}
