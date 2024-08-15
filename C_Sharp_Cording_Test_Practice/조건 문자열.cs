using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열에 따라 다음과 같이 두 수의 크기를 비교하려고 합니다.
 * 
 * 두 수가 n과 m이라면
 * ">", "=" : n >= m
 * "<", "=" : n <= m
 * ">", "!" : n > m
 * "<", "!" : n < m
 * 두 문자열 ineq와 eq가 주어집니다. 
 * 
 * ineq는 "<"와 ">"중 하나고, eq는 "="와 "!"중 하나입니다. 
 * 그리고 두 정수 n과 m이 주어질 때, n과 m이 ineq와 eq의 조건에 맞으면 1을 아니면 0을 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string ineq, string eq, int n, int m)
        {
            int answer = 0;
            if(ineq.Equals(">"))
            {
                if(eq.Equals("!"))
                {
                    answer = n > m ? 1 : 0;
                }
                else if (eq.Equals("="))
                {
                    answer = n >= m ? 1 : 0;
                }
            }
            else if(ineq.Equals("<"))
            {
                if (eq.Equals("!"))
                {
                    answer = n < m ? 1 : 0;
                }
                else if (eq.Equals("="))
                {
                    answer = n <= m ? 1 : 0;
                }
            }
            return answer;
        }
    }
    class 조건_문자열
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution("<", "=", 20, 50));
            Console.WriteLine(_solution.solution(">", "!", 41, 78));
        }
    }
    */
}