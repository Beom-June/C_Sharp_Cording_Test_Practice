using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 괄호가 바르게 짝지어졌다는 것은 '(' 문자로 열렸으면 반드시 짝지어서 
 * ')' 문자로 닫혀야 한다는 뜻입니다. 
 * 
 * 예를 들어
 * "()()" 또는 "(())()" 는 올바른 괄호입니다.
 * ")()(" 또는 "(()(" 는 올바르지 않은 괄호입니다.
 * '(' 또는 ')' 로만 이루어진 문자열 s가 주어졌을 때, 
 * 문자열 s가 올바른 괄호이면 true를 return 하고, 
 * 올바르지 않은 괄호이면 false를 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public bool solution(string s)
        {
            bool answer = true;
            int _cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(')
                {
                    answer = false;
                    _cnt++;
                }
                else if(s[i] == ')')
                {
                    if(_cnt == 0)
                    {
                        answer = false;
                        break;
                    }
                    if(_cnt > 0)
                    {
                        _cnt--;
                        answer = true;
                    }
                }
            }
            if (_cnt > 0)
            {
                answer = false;
            }
            return answer;
        }
    }
    class 올바른_괄호
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s1 = "()()";
            string _s2 = "(())()";
            string _s3 = ")()(";
            string _s4 = "(()(";

            Console.WriteLine(_solution.solution(_s1));     //  true
            Console.WriteLine(_solution.solution(_s2));     //  true
            Console.WriteLine(_solution.solution(_s3));     //  false
            Console.WriteLine(_solution.solution(_s4));     //  false
        }
    }
    */
}