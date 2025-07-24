using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 정수 a, b가 주어졌을 때 a와 b 사이에 속한 모든 정수의 합을 리턴하는 함수, 
 * solution을 완성하세요.
 * 
 * 예를 들어 a = 3, b = 5인 경우, 3 + 4 + 5 = 12이므로 12를 리턴합니다.
 * 
 * 제한 조건
 * a와 b가 같은 경우는 둘 중 아무 수나 리턴하세요.
 * a와 b는 -10,000,000 이상 10,000,000 이하인 정수입니다.
 * a와 b의 대소관계는 정해져있지 않습니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public long solution(int a, int b)
        {
            long answer = 0;

            int _min = Math.Min(a, b);
            int _max = Math.Max(a, b);

            for (int i = _min; i <= _max; i++)
            {
                answer += i;
            }
            return answer;
        }
    }
    class 두_정수_사이의_합
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _a1 = 3, _a2 = 3, _a3 = 5;
            int _b1 = 5, _b2 = 3, _b3 = 3;

            Console.WriteLine(_solution.solution(_a1, _b1));
            Console.WriteLine(_solution.solution(_a2, _b2));
            Console.WriteLine(_solution.solution(_a3, _b3));
        }
    }
    */
}
