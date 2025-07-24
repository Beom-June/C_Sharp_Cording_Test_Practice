using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 배열 numbers와 정수 n이 매개변수로 주어집니다. 
 * numbers의 원소를 앞에서부터 하나씩 더하다가 그 합이 n보다 커지는 
 * 순간 이때까지 더했던 원소들의 합을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] numbers, int n)
        {
            int answer = 0;
            int _sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                // 더하기
                _sum += numbers[i];

                // 만약 합이 n보다 커지면
                if(_sum > n)
                {
                    answer = _sum;
                    break;
                }
            }

            return answer;
        }
    }
    class n보다_커질_때까지_더하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers1 = { 34, 5, 71, 29, 100, 34 };
            int[] _numbers2 = { 58, 44, 27, 10, 100 };

            int _n1 = 123;
            int _n2 = 139;

            Console.WriteLine(_solution.solution(_numbers1, _n1));
            Console.WriteLine(_solution.solution(_numbers2, _n2));
        }
    }
    */
}
