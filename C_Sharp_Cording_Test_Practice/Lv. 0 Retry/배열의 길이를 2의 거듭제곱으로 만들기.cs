using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 arr이 매개변수로 주어집니다. 
 * arr의 길이가 2의 정수 거듭제곱이 되도록 arr 뒤에 정수 0을 추가하려고 합니다. 
 * arr에 최소한의 개수로 0을 추가한 배열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            int _n = arr.Length;
            int _Size = 1;

            // 새로운 배열 크기 결정
            while (_Size < _n)
            {
                _Size *= 2;
            }

            int[] answer = new int[_Size];

            // 기존 배열 값 복사
            for (int i = 0; i < _n; i++)
            {
                answer[i] = arr[i];
            }
            return answer;
        }
    }
    class 배열의_길이를_2의_거듭제곱으로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] _arr2 = { 58, 172, 746, 89 };

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
        }
    }
    */
}
