using System;
using System.Collections.Generic;

/* 정수 리스트 num_list와 정수 n이 주어질 때, 
 * num_list를 n 번째 원소 이후의 원소들과 
 * n 번째까지의 원소들로 나눠 n 번째 원소 이후의 원소들을 n 번째까지의 
 * 원소들 앞에 붙인 리스트를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] num_list, int n)
        {
            List<int> answer = new List<int>();
            for (int i = n; i < num_list.Length; i++)
            {
                answer.Add(num_list[i]);
            }
            for (int i = 0; i < n; i++)
            {
                answer.Add(num_list[i]);
            }
            return answer.ToArray();
        }
    }
    class 순서_바꾸기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numList01 = { 2, 1, 6 };
            int[] _numList02 = { 5, 2, 1, 7, 5 };

            foreach (var item in _solution.solution(_numList01, 1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in _solution.solution(_numList02, 3))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    */
}