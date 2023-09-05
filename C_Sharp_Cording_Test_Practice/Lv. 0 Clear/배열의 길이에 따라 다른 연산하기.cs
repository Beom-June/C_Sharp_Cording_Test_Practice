using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 배열 arr과 정수 n이 매개변수로 주어집니다. 
 * arr의 길이가 홀수라면 arr의 모든 짝수 인덱스 위치에 n을 더한 배열을, 
 * arr의 길이가 짝수라면 arr의 모든 홀수 인덱스 위치에 n을 더한 배열을 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int n)
        {
            List<int> _answer = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr.Length % 2 != 0)
                {
                    // 배열의 길이가 홀수인 경우
                    if (i % 2 == 0)
                    {
                        _answer.Add(arr[i] + n);
                    }
                    else
                    {
                        _answer.Add(arr[i]);
                    }
                }
                else
                {
                    // 배열의 길이가 짝수인 경우
                    if (i % 2 != 0)
                    {
                        _answer.Add(arr[i] + n);
                    }
                    else
                    {
                        _answer.Add(arr[i]);
                    }
                }
            }
            return _answer.ToArray();
        }
    }
    class 배열의_길이에_따라_다른_연산하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr1 = { 49, 12, 100, 276, 33 };
            int[] _arr2 = { 444, 555, 666, 777 };

            int _n1 = 27, _n2 = 100;

            foreach (var _result in _solution.solution(_arr1, _n1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_arr2, _n2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
