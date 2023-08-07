using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 양의 정수 n이 매개변수로 주어질 때, 
 * n이 홀수라면 n 이하의 홀수인 모든 양의 정수의 합을 return 하고 
 * n이 짝수라면 n 이하의 짝수인 모든 양의 정수의 제곱의 합을 return 하는 
 * solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            if (n % 2 == 0)
            {
                for (int i = 2; i <= n; i += 2)
                {
                    answer += i * i;
                }
            }
            else
            {
                for (int i = 1; i <= n; i += 2)
                {
                    answer += i;
                }
            }
            return answer;
        }
    }
    class 홀짝에_따라_다른_값_반환하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n1 = 7;
            int _n2 = 10;

            Console.WriteLine(_solution.solution(_n1));
            Console.WriteLine(_solution.solution(_n2));
        }
    }
    */
}
