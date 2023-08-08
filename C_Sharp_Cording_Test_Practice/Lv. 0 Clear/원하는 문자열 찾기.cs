using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 알파벳으로 이루어진 문자열 myString과 pat이 주어집니다. 
 * myString의 연속된 부분 문자열 중 pat이 존재하면 1을 그렇지 않으면 0을 
 * return 하는 solution 함수를 완성해 주세요.
 * 단, 알파벳 대문자와 소문자는 구분하지 않습니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string myString, string pat)
        {
            int answer = 0;

            string _my = myString.ToLower();
            string _pat = pat.ToLower();

            for (int i = 0; i <= _my.Length - _pat.Length; i++)
            {
                if (_my.Substring(i, _pat.Length) == _pat)
                {
                    answer = 1;
                    break;
                }
            }
            return answer;
        }
    }
    class 원하는_문자열_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString1 = "AbCdEfG";
            string _myString2 = "aaAA";

            string _pat1 = "aBc";
            string _pat2 = "aaaaa";

            Console.WriteLine(_solution.solution(_myString1, _pat1));
            Console.WriteLine(_solution.solution(_myString2, _pat2));
        }
    }
    */
}
