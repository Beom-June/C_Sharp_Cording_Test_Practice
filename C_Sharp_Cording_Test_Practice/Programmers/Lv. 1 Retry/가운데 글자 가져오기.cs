using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요. 
 * 
 * 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";

            //  짝수
            if (s.Length % 2 == 0)
            {
                // 각 글자를 더해줌
                answer += s[s.Length / 2 - 1];
                answer += s[s.Length / 2];
            }
            //  홀수
            else
            {
                // 홀수는 문자열길이의 절반이 중간글자
                answer += s[s.Length / 2];
            }
            return answer;
        }
    }
    class 가운데_글자_가져오기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s1 = "abcde";
            string _s2 = "qwer";

            Console.WriteLine(_solution.solution(_s1));
            Console.WriteLine(_solution.solution(_s2));
        }
    }
    */
}