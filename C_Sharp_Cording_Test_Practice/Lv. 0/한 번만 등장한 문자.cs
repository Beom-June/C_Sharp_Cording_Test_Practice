using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 s가 매개변수로 주어집니다. 
 * s에서 한 번만 등장하는 문자를 사전 순으로 정렬한 문자열을 
 * return 하도록 solution 함수를 완성해보세요. 
 * 한 번만 등장하는 문자가 없을 경우 빈 문자열을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            int _cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        _cnt++;
                    }
                }
                if (_cnt == 1)
                {
                    answer += s[i];
                }
                _cnt = 0;
            }
            // OrderBy()는 요소를 오름차순으로 정렬한다.
            answer = string.Concat(answer.OrderBy(x => x));
            return answer;
        }
    }
    class 한_번만_등장한_문자
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s1 = "abcabcadc";
            string _s2 = "abdc";
            string _s3 = "hello";

            Console.WriteLine(_solution.solution(_s1));
            Console.WriteLine(_solution.solution(_s2));
            Console.WriteLine(_solution.solution(_s3));
        }
    }
    */
}
