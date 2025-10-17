using System;
using System.Collections.Generic;

/* 괄호가 바르게 짝지어졌다는 것은 '(' 문자로 열렸으면 반드시 짝지어서 ')' 문자로 닫혀야 한다는 뜻입니다. 
 * 
 * 예를 들어
 * "()()" 또는 "(())()" 는 올바른 괄호입니다.
 * ")()(" 또는 "(()(" 는 올바르지 않은 괄호입니다.
 * '(' 또는 ')' 로만 이루어진 문자열 s가 주어졌을 때, 
 * 
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
            Stack<char> _sStack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(')
                {
                    _sStack.Push(c);
                }
                else if (c == ')')
                {
                    if (_sStack.Count > 0)
                        _sStack.Pop();
                    else
                        return false; // 닫는 괄호가 너무 많으면 false
                }
            }

            // 스택이 비어 있으면 올바른 괄호, 아니면 false
            return _sStack.Count == 0;
        }
    }
    internal class 올바른_괄호
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s01 = "()()";
            string _s02 = "(())()";
            string _s03 = ")()(";
            string _s04 = "(()(";

            Console.WriteLine(_solution.solution(_s01));        //  true
            Console.WriteLine(_solution.solution(_s02));        //  true
            Console.WriteLine(_solution.solution(_s03));        //  flase
            Console.WriteLine(_solution.solution(_s04));        //  flase
        }
    }
    */
}
