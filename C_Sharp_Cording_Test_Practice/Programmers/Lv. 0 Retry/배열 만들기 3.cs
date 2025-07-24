using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 arr와 2개의 구간이 담긴 배열 intervals가 주어집니다.
 * 
 * intervals는 항상 [[a1, b1], [a2, b2]]의 꼴로 주어지며 각 구간은 닫힌 구간입니다. 
 * 닫힌 구간은 양 끝값과 그 사이의 값을 모두 포함하는 구간을 의미합니다.
 * 
 * 이때 배열 arr의 첫 번째 구간에 해당하는 배열과 두 번째 구간에 해당하는 
 * 배열을 앞뒤로 붙여 새로운 배열을 만들어 return 하는 solution 함수를 완성해 주세요
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int[,] intervals)
        {
            List<int> _answer = new List<int>();

            // 첫 번째 구간의 시작과 끝 인덱스
            int _start1 = intervals[0, 0];
            int _end1 = intervals[0, 1];

            // 두 번째 구간의 시작과 끝 인덱스
            int _start2 = intervals[1, 0];
            int _end2 = intervals[1, 1];

            // 첫 번째 구간의 배열을 _answer에 추가
            for (int i = _start1; i <= _end1; i++)
            {
                _answer.Add(arr[i]);
            }

            // 두 번째 구간의 배열을 _answer에 추가
            for (int i = _start2; i <= _end2; i++)
            {
                _answer.Add(arr[i]);
            }

            return _answer.ToArray();
        }
    }
    class 배열_만들기_3
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 1, 2, 3, 4, 5 };
            int[,] _intervals = { { 1, 3 }, { 0, 4 } };

            foreach (var _result in _solution.solution(_arr, _intervals))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
