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
            int[] answer = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i];
                if (arr.Length % 2 == 1 && i % 2 == 0)
                {
                    answer[i] += n;
                }
                else if (arr.Length % 2 == 0 && i % 2 == 1)
                {
                    answer[i] += n;
                }
            }
            return answer;
        }
    }
    class 배열의_길이에_따라_다른_연산하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr01 = { 49, 12, 100, 276, 33 };
            int[] _arr02 = { 444, 555, 666, 777 };

            foreach (var item in _solution.solution(_arr01, 27))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in _solution.solution(_arr02, 100))
            {
                Console.Write(item + " ");
            }
        }
    }
    */
}
