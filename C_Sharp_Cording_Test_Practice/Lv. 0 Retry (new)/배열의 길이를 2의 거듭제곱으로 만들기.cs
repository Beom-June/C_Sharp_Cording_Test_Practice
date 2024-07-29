using System;
using System.Collections.Generic;

/* Retry
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
            List<int> answer = new List<int>(arr);

            int powerOfTwoLength = 1;
            // 2의 거듭제곱 중 arr.Length보다 크거나 같은 수를 찾음
            while (powerOfTwoLength < arr.Length)
            {
                powerOfTwoLength *= 2;
            }

            // 필요한 개수만큼 0을 추가
            int zerosToAdd = powerOfTwoLength - arr.Length;
            for (int i = 0; i < zerosToAdd; i++)
            {
                answer.Add(0);
            }
            return answer.ToArray();
        }
    }
    class 배열의_길이를_2의_거듭제곱으로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr01 = { 1, 2, 3, 4, 5, 6 };
            int[] _arr02 = { 58, 172, 746, 89 };

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
        }
    }
    */
}