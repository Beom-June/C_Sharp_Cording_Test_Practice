using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 array와 정수 n이 매개변수로 주어질 때, 
 * array에 들어있는 정수 중 n과 가장 가까운 수를 
 * return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] array, int n)
        {
            int answer = array[0];

            foreach (int num in array)
            {
                // 절댓값 표현
                int diff = Math.Abs(n - num);
                int prevDiff = Math.Abs(n - answer);
                
                    if (diff == prevDiff)
        {
            answer = Math.Min(answer, num);
        }
                // num이 answer보다 n과 더 가까우면?
                else if (diff < prevDiff)
                {
                    answer = num;
                }
            }

            return answer;
        }
    }
    class 가까운_수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _array1 = { 3, 10, 28 };
            int[] _array2 = { 10, 11, 12 };

            int _n1 = 20;
            int _n2 = 13;

            Console.WriteLine(_solution.solution(_array1, _n1));
            Console.WriteLine(_solution.solution(_array2, _n2));
        }
    }
    */
}
