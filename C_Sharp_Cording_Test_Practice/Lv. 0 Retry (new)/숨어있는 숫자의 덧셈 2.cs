using System;
using System.Text.RegularExpressions;

/* 문자열 my_string이 매개변수로 주어집니다. 
 * my_string은 소문자, 대문자, 자연수로만 구성되어있습니다. 
 * my_string안의 자연수들의 합을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string my_string)
        {
            int answer = 0;
            // 정규 표현식을 사용하여 문자열에서 숫자를 찾습니다.
            MatchCollection _match = Regex.Matches(my_string, @"\d+");

            // 찾은 숫자들을 합산합니다.
            foreach (Match m in _match)
            {
                answer += int.Parse(m.Value);
            }

            return answer;
        }
    }
    class 숨어있는_숫자의_덧셈_2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution("aAb1B2cC34oOp"));     //  37
            Console.WriteLine(_solution.solution("1a2b3c4d123Z"));      //  133
        }
    }
    */
}