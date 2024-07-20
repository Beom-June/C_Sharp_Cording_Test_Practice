using System;
using System.Collections.Generic;

/* 정수 배열 arr와 자연수 k가 주어집니다.
 * 
 * 만약 k가 홀수라면 arr의 모든 원소에 k를 곱하고, k가 짝수라면 arr의 모든 원소에 k를 더합니다.
 * 이러한 변환을 마친 후의 arr를 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int k)
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                //  k 홀수
                if( k % 2 == 1)
                {
                    answer.Add(arr[i] * k);
                }
                //  k 짝수
                else
                {
                    answer.Add(arr[i] + k);
                }
            }
            return answer.ToArray();
        }
    }
    class 조건에_맞게_수열_변환하기_3
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 1, 2, 3, 100, 99, 98 };

            foreach (var item in _solution.solution(_arr, 3))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in _solution.solution(_arr, 2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    */
}