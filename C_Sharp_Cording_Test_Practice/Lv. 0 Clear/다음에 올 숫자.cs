using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 등차수열 혹은 등비수열 common이 매개변수로 주어질 때, 
 * 마지막 원소 다음으로 올 숫자를 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] common)
        {
            int answer = 0;
            // 등차수열 확인
            if (common[2] - common[1] == common[1] - common[0])
            {
                answer = common[common.Length - 1] + (common[1] - common[0]);
            }
            // 등비수열 확인
            else
            {
                answer = common[common.Length - 1] * (common[1] / common[0]);
            }
            return answer;
        }
    }
    class 다음에_올_숫자
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _common1 = { 1, 2, 3, 4 };
            int[] _common2 = { 2, 4, 8 };

            Console.WriteLine(_solution.solution(_common1));
            Console.WriteLine(_solution.solution(_common2));
        }
    }
    */
}
