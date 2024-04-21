using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * JadenCase란 모든 단어의 첫 문자가 대문자이고, 그 외의 알파벳은 소문자인 문자열입니다. 
 * 
 * 단, 첫 문자가 알파벳이 아닐 때에는 이어지는 알파벳은 소문자로 쓰면 됩니다. 
 * (첫 번째 입출력 예 참고)
 * 
 * 문자열 s가 주어졌을 때, s를 JadenCase로 바꾼 문자열을 리턴하는 함수, solution을 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            bool _isUp = true;
            foreach (char _char in s)
            {
                answer += (_isUp) ? _char.ToString().ToUpper() : _char.ToString().ToLower();
                _isUp = (_char == ' ');
            }
            return answer;
        }
    }
    class JadenCase_문자열_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s1 = "3people unFollowed me";
            string _s2 = "for the last week";

            Console.WriteLine(_solution.solution(_s1));
            Console.WriteLine(_solution.solution(_s2));
        }
    }
    */
}