﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 arr와 2차원 정수 배열 queries이 주어집니다. 
 * queries의 원소는 각각 하나의 query를 나타내며, [s, e, k] 꼴입니다.
 * 
 * 각 query마다 순서대로 s ≤ i ≤ e인 모든 i에 대해 i가 k의 배수이면 arr[i]에 1을 더합니다.
 * 
 * 위 규칙에 따라 queries를 처리한 이후의 arr를 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
        {
            int[] answer = new int[arr.Length];

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int s = queries[i, 0];
                int e = queries[i, 1];
                int k = queries[i, 2];

                for (int j = s; j <= e; j++)
                {
                    if (j % k == 0)
                    {
                        arr[j] += 1;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i];
            }

            return answer;
        }
    }
    class 수열과_구간_쿼리_4
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 0, 1, 2, 4, 3 };
            int[,] _queries = { { 0, 4, 1 }, { 0, 3, 2 }, { 0, 3, 3 } };

            foreach (var solution in _solution.solution(_arr, _queries))
            {
                Console.Write(solution + " ");
            }
        }
    }
    */
}
