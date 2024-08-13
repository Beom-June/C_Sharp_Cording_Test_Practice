using System;
using System.Collections.Generic;
using System.Linq;

/* 정수 배열 arr가 주어집니다. arr를 이용해 새로운 배열 stk를 만드려고 합니다.
 * 
 * 변수 i를 만들어 초기값을 0으로 설정한 후 i가 arr의 길이보다 작으면 다음 작업을 반복합니다.
 * 
 * 만약 stk가 빈 배열이라면 arr[i]를 stk에 추가하고 i에 1을 더합니다.
 * stk에 원소가 있고, stk의 마지막 원소가 arr[i]보다 작으면 arr[i]를 stk의 뒤에 추가하고 i에 1을 더합니다.
 * stk에 원소가 있는데 stk의 마지막 원소가 arr[i]보다 크거나 같으면 stk의 마지막 원소를 stk에서 제거합니다.
 * 위 작업을 마친 후 만들어진 stk를 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            List<int> stk = new List<int>();

            int i = 0;  // i 초기값을 0으로 설정
            while (i < arr.Length)
            {
                if (stk.Count == 0)
                {
                    // stk가 빈 배열이면 arr[i] 추가
                    stk.Add(arr[i]);
                    i++; // i 증가
                }
                else
                {
                    // stk의 마지막 원소가 arr[i]보다 작으면
                    if (stk.Last() < arr[i])
                    {
                        stk.Add(arr[i]);  // arr[i]를 stk에 추가
                        i++; // i 증가
                    }
                    else
                    {
                        stk.RemoveAt(stk.Count - 1);  // stk의 마지막 원소를 제거
                    }
                }
            }

            return stk.ToArray();
        }
    }
    class 배열_만들기_4
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 1, 4, 2, 5, 3 };

            foreach (var i in _solution.solution(_arr))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}