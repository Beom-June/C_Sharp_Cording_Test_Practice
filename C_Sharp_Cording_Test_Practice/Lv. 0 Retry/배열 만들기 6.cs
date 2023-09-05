using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 0과 1로만 이루어진 정수 배열 arr가 주어집니다. 
 * arr를 이용해 새로운 배열 stk을 만드려고 합니다.
 * 
 * i의 초기값을 0으로 설정하고 i가 arr의 길이보다 작으면 다음을 반복합니다.
 * 
 * 만약 stk이 빈 배열이라면 arr[i]를 stk에 추가하고 i에 1을 더합니다.
 * stk에 원소가 있고, stk의 마지막 원소가 arr[i]와 같으면 stk의 마지막 원소를 
 * stk에서 제거하고 i에 1을 더합니다.
 * stk에 원소가 있는데 stk의 마지막 원소가 arr[i]와 다르면 stk의 
 * 맨 마지막에 arr[i]를 추가하고 i에 1을 더합니다.
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
            List<int> _answer = new List<int>();
            int i = 0;

            while (i < arr.Length)
            {
                // 빈 배열이면
                if (_answer.Count == 0)
                {
                    _answer.Add(arr[i]);
                    i++;
                }
                // 마지막 원소가 arr[i]와 같으면
                else if (_answer[_answer.Count - 1] == arr[i])
                {
                    _answer.RemoveAt(_answer.Count - 1);
                    i++;
                }
                // 마지막 원소가 arr[i]와 다르면
                else
                {
                    _answer.Add(arr[i]);
                    i++;
                }
            }

            //  빈 배열을 리턴해야 한다면
            if (_answer.Count == 0)
            {
                return new int[] { -1 };
            }
            else
            {
                return _answer.ToArray();
            }
        }
    }
    class 배열_만들기_6
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr1 = { 0, 1, 1, 1, 0 };
            int[] _arr2 = { 0, 1, 0, 1, 0 };
            int[] _arr3 = { 0, 1, 1, 0 };

            foreach (var _result in _solution.solution(_arr1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_arr2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_arr3))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

        }
    }
    */
}
