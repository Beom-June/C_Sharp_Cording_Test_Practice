using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 n과 k가 주어졌을 때, 1 이상 n이하의 정수 중에서 
 * k의 배수를 오름차순으로 저장한 배열을 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int n, int k)
        {
            int[] answer = new int[n / k]; // k의 배수의 개수를 저장할 배열

            for (int i = 1; i <= n / k; i++)
            {
                    answer[i - 1] = k * i; // k의 배수 계산 및 저장
            }
            return answer;
        }
    }
    class 배열_만들기_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n1 = 10, _n2 = 15;
            int _k1 = 3, _k2 = 5;

            foreach (var _result in _solution.solution(_n1, _k1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_n2, _k2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
