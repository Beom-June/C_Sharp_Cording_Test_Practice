using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 numbers가 매개변수로 주어집니다. 
 * numbers의 원소 중 두 개를 곱해 만들 수 있는 
 * 최댓값을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] numbers)
        {
            int answer = 0;
            List<int> _list = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == j)
                        continue;
                    else
                        _list.Add(numbers[i] * numbers[j]);

                }
            }
            // 최댓값 찾기
            answer = _list.Max();
            return answer;
        }
    }
    class 최댓값_만들기__2_
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers1 = { 1, 2, -3, 4, -5 };
            int[] _numbers2 = { 0, -31, 24, 10, 1, 9 };
            int[] _numbers3 = { 10, 20, 30, 5, 5, 20, 5 };

            Console.WriteLine(_solution.solution(_numbers1));
            Console.WriteLine(_solution.solution(_numbers2));
            Console.WriteLine(_solution.solution(_numbers3));
        }
    }
    */
}
