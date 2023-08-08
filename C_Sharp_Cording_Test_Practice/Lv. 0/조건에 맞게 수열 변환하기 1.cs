using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 배열 arr가 주어집니다. 
 * arr의 각 원소에 대해 값이 50보다 크거나 같은 짝수라면 2로 나누고, 
 * 50보다 작은 홀수라면 2를 곱합니다. 그 결과인 정수 배열을 
 * return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            int[] answer = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                // 50 이상, 짝수
                if (arr[i] >= 50 && arr[i] % 2 == 0)
                {
                    answer[i] = arr[i] / 2;
                }
                
                // 50미만 홀수
                else if (arr[i] < 50 && arr[i] % 2 == 1)
                {
                    answer[i] = arr[i] * 2;
                }

                // 나머지
                else
                {
                    answer[i] = arr[i];
                }
            }
            return answer;
        }
    }
    class 조건에_맞게_수열_변환하기_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 1, 2, 3, 100, 99, 98 };

            foreach (var num in _solution.solution(_arr))
            {
                Console.Write(num + " ");
            }
        }
    }
    */
}
