using System;
using System.Text.RegularExpressions;

/* Retry
 * 문자열 my_string이 매개변수로 주어집니다. 
 * my_string안의 모든 자연수들의 합을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string my_string)
        {
            int answer = 0;
            // 정규식을 사용하여 문자열에서 숫자 추출
            MatchCollection matches = Regex.Matches(my_string, @"\d");

            // 추출한 숫자들을 합산
            foreach (Match match in matches)
            {
                answer += int.Parse(match.Value);
            }
            return answer;
        }
    }
    class 숨어있는_숫자의_덧셈_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string01 = "aAb1B2cC34oOp";
            string _my_string02 = "1a2b3c4d123";

            Console.WriteLine(_solution.solution(_my_string01));
            Console.WriteLine(_solution.solution(_my_string02));
        }
    }
    */
}
