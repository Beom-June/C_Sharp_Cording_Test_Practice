using System;
using System.Collections.Generic;
using System.Linq;

/* 0과 1로만 이루어진 정수 배열 arr가 주어집니다. arr를 이용해 새로운 배열 stk을 만드려고 합니다.
 * 
 * i의 초기값을 0으로 설정하고 i가 arr의 길이보다 작으면 다음을 반복합니다.
 * 
 * 만약 stk이 빈 배열이라면 arr[i]를 stk에 추가하고 i에 1을 더합니다.
 * 
 * stk에 원소가 있고, stk의 마지막 원소가 arr[i]와 같으면 
 * stk의 마지막 원소를 stk에서 제거하고 i에 1을 더합니다.
 * 
 * stk에 원소가 있는데 stk의 마지막 원소가 arr[i]와 다르면 
 * stk의 맨 마지막에 arr[i]를 추가하고 i에 1을 더합니다.
 * 위 작업을 마친 후 만들어진 stk을 return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, 만약 빈 배열을 return 해야한다면 [-1]을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            List<int> _stk = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                //  _stk 빈 배열 -> arr[i] 를 stk에 추가 i를 더함
                if(_stk.Count == 0)
                {
                    _stk.Add(arr[i]);
                }
                else
                {
                    // stk의 마지막 요소가 arr[i]와 같다면 stk에서 제거
                    if (_stk.Last() == arr[i])
                    {
                        _stk.RemoveAt(_stk.Count - 1);
                    }
                    else
                    {
                        // 그렇지 않다면 현재 arr[i]를 추가
                        _stk.Add(arr[i]);
                    }
                }

            }
            // stk이 비어있다면 [-1]을 반환, 그렇지 않으면 stk의 배열을 반환
            return _stk.Count == 0 ? new int[] { -1 } : _stk.ToArray();
        }
    }
    class 배열_만들기_6
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr01 = { 0, 1, 1, 1, 0 };
            int[] _arr02 = { 0, 1, 0, 1, 0 };
            int[] _arr03 = { 0, 1, 1, 0 };

            foreach (var i in _solution.solution(_arr01))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (var i in _solution.solution(_arr02))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (var i in _solution.solution(_arr03))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}