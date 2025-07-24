using System;
using System.Linq;

/* Retry
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
            int _start = Array.IndexOf(arr, 2);

            if (_start == -1) 
                return new int[] { -1 };

            int _end = Array.LastIndexOf(arr, 2);

            int[] answer = new int[_end - _start + 1];

            Array.Copy(arr, _start, answer, 0, answer.Length);

            return answer.ToArray();
        }
    }
    class _2의_영역
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr01 = { 1, 2, 1, 4, 5, 2, 9 };
            int[] _arr02 = { 1, 2, 1 };
            int[] _arr03 = { 1, 1, 1 };
            int[] _arr04 = { 1, 2, 1, 2, 1, 10, 2, 1 };

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

            foreach (var i in _solution.solution(_arr04))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}