using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 자연수 n이 매개변수로 주어집니다. n을 3진법 상에서 앞뒤로 뒤집은 후, 
 * 이를 다시 10진법으로 표현한 수를 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int n)
        {
            // 10진수를 3진수로 변환
            string _10n = "";
            while (n > 0)
            {
                _10n = (n % 3).ToString() + _10n;
                n /= 3;
            }

            // 3진수를 뒤집어서 다시 10진수로 변환
            int answer = 0;
            for (int i = 0; i < _10n.Length; i++)
            {
                answer += (_10n[i] - '0') * (int)Math.Pow(3, i);
            }

            return answer;
        }
    }
    class _3진법_뒤집기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n1 = 45, _n2 = 125;

            Console.WriteLine(_solution.solution(_n1));
            Console.WriteLine(_solution.solution(_n2));
        }
    }
    */
}
