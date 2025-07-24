using System;
using System.Collections.Generic;

/* Retry
 * 정수 l과 r이 주어졌을 때, l 이상 r이하의 정수 중에서 
 * 숫자 "0"과 "5"로만 이루어진 모든 정수를 오름차순으로 저장한 배열을 
 * return 하는 solution 함수를 완성해 주세요.
 * 
 * 만약 그러한 정수가 없다면, -1이 담긴 배열을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int l, int r)
        {
            List<int> answer = new List<int>();
            bool _checking;

            for (int i = l; i <= r; i++)
            {
                _checking = true;

                foreach (var c in i.ToString())
                {
                    if (c == '0' || c == '5')
                    {
                        _checking = true;
                        continue;
                    }
                    else
                    {
                        _checking = false;
                        break;
                    }
                }

                if (_checking)
                    answer.Add(i);
            }

            if (answer.Count == 0)
                answer.Add(-1);

            return answer.ToArray();
        }
    }
    class 배열_만들기_2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            // 5, 50, 55, 500, 505, 550, 555
            foreach (var i in _solution.solution(5, 555))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // -1
            foreach (var i in _solution.solution(10, 20))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}