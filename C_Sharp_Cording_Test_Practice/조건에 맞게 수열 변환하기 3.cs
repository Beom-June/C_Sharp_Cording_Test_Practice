using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 배열 arr와 자연수 k가 주어집니다.
 * 만약 k가 홀수라면 arr의 모든 원소에 k를 곱하고, 
 * k가 짝수라면 arr의 모든 원소에 k를 더합니다.
 * 
 * 이러한 변환을 마친 후의 arr를 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int k)
        {
            int[] answer = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (k % 2 == 0)
                {
                    answer[i] = arr[i] + k;
                }
                else
                {
                    answer[i] = arr[i] * k;
                }

            }
            return answer;
        }
    }
    class 조건에_맞게_수열_변환하기_3
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 1, 2, 3, 100, 99, 98 };
            int _k1 = 3, _k2 = 2;

            foreach (var _result in _solution.solution(_arr, _k1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_arr, _k2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
