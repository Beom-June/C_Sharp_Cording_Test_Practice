﻿using System;
using System.Linq;

/* Retry
 * 정수 배열 arr가 주어집니다. arr의 각 원소에 대해 값이 50보다 크거나 같은 짝수라면 2로 나누고, 
 * 50보다 작은 홀수라면 2를 곱하고 다시 1을 더합니다.
 * 
 * 이러한 작업을 x번 반복한 결과인 배열을 arr(x)라고 표현했을 때, 
 * arr(x) = arr(x + 1)인 x가 항상 존재합니다. 이러한 x 중 가장 작은 값을 
 * return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, 두 배열에 대한 "="는 두 배열의 크기가 서로 같으며, 같은 인덱스의 원소가 각각 서로 같음을 의미합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] arr)
        {
            int answer = 0;
            int[] _preArr;

            while (true)
            {
                //  배열저장
                _preArr = (int[])arr.Clone();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 50 && arr[i] % 2 == 0)
                    {
                        arr[i] /= 2;
                    }
                    else if (arr[i] < 50 && arr[i] % 2 != 0)
                    {
                        arr[i] = arr[i] * 2 + 1;
                    }
                }

                answer++;

                // 이전 배열과 변환된 배열이 같으면 반복 중지
                if (Enumerable.SequenceEqual(_preArr, arr))
                {
                    break;
                }
            }

            //  마지막에서 반복이 없음
            return answer - 1;
        }
    }
    class 조건에_맞게_수열_변환하기_2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 1, 2, 3, 100, 99, 98 };

            Console.WriteLine(_solution.solution(_arr));        //  5
        }
    }
    */
}