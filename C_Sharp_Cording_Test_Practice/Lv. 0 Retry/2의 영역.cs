using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 arr가 주어집니다. 
 * 배열 안의 2가 모두 포함된 가장 작은 연속된 부분 배열을 
 * return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, arr에 2가 없는 경우 [-1]을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            // 앞쪽 인덱스
            int _start = Array.IndexOf(arr, 2);

            if (_start == -1) 
                return new int[] { -1 };

            // 뒤쪽 인덱스
            int _end = Array.LastIndexOf(arr, 2);

            int[] _answer = new int[_end - _start + 1];

            Array.Copy(arr, _start, _answer, 0, _answer.Length);

            return _answer;
        }
    }
    class _2의_영역
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr1 = { 1, 2, 1, 4, 5, 2, 9 };
            int[] _arr2 = { 1, 2, 1 };
            int[] _arr3 = { 1, 1, 1 };
            int[] _arr4 = { 1, 2, 1, 2, 1, 10, 2, 1 };

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

            foreach (var _result in _solution.solution(_arr4))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

        }
    }
    */
}
