using System;
using System.Text;

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
            StringBuilder answer = new StringBuilder();
            for (int i = 0; i < code.Length; i++)
            {
                if (i % q == r)
                {
                    answer.Append(code[i]);
                }
            }
            return answer.ToString();
        }
    }
    class qr_code
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(3, 1, "qjnwezgrpirldywt"));    //  "jerry"
            Console.WriteLine(_solution.solution(1, 0, "programmers"));         //  "programmers"
        }
    }
    */
}