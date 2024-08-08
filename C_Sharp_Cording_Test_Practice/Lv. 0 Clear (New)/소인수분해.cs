using System;
using System.Collections.Generic;
using System.Linq;

/* 소인수분해란 어떤 수를 소수들의 곱으로 표현하는 것입니다. 
 * 예를 들어 12를 소인수 분해하면 2 * 2 * 3 으로 나타낼 수 있습니다. 
 * 따라서 12의 소인수는 2와 3입니다. 
 * 
 * 자연수 n이 매개변수로 주어질 때 n의 소인수를 오름차순으로 담은 배열을 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int n)
        {
            List<int> answer = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    answer.Add(i);
                    n /= i;
                }
            }
            //  중복 제거 후, 배열
            return answer.Distinct().ToArray();
        }
    }
    class 소인수분해
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            foreach (var i in _solution.solution(12))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (var i in _solution.solution(17))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (var i in _solution.solution(420))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}