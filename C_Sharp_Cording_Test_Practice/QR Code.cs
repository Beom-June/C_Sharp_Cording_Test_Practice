using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 정수 q, r과 문자열 code가 주어질 때, 
 * code의 각 인덱스를 q로 나누었을 때 나머지가 r인 위치의 
 * 문자를 앞에서부터 순서대로 이어 붙인 문자열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(int q, int r, string code)
        {
            string answer = "";

            for (int i = 0; i < code.Length; i++)
            {
                if (i % q == r)
                {
                    answer += code[i];
                }
            }
            return answer;
        }
    }
    class QR_Code
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _q1 = 3, _q2 = 1;
            int _r1 = 1, _r2 = 0;
            string _code1 = "qjnwezgrpirldywt";
            string _code2 = "programmers";

            Console.WriteLine(_solution.solution(_q1, _r1, _code1));
            Console.WriteLine(_solution.solution(_q2, _r2, _code2));
        }
    }
    */
}
