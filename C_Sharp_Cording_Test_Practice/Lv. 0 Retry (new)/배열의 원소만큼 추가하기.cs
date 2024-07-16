using System;
using System.Collections.Generic;

/* Retry
 * 아무 원소도 들어있지 않은 빈 배열 X가 있습니다. 
 * 
 * 양의 정수 배열 arr가 매개변수로 주어질 때, 
 * arr의 앞에서부터 차례대로 원소를 보면서 원소가 a라면 X의 맨 뒤에 
 * a를 a번 추가하는 일을 반복한 뒤의 배열 X를 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            List<int> answer = new List<int>();

            foreach (int num in arr)
            {
                for (int i = 0; i < num; i++)
                {
                    answer.Add(num);
                }
            }

            return answer.ToArray();
        }
    }
    class 배열의_원소만큼_추가하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr01 = { 5, 1, 4 };
            int[] _arr02 = { 6,6 };
            int[] _arr03 = { 1 };

            foreach (var item in _solution.solution(_arr01))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in _solution.solution(_arr02))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in _solution.solution(_arr03))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
