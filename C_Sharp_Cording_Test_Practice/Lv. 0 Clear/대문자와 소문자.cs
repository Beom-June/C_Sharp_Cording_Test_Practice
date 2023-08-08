using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 my_string이 매개변수로 주어질 때, 
 * 대문자는 소문자로 소문자는 대문자로 변환한 문자열을 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string)
        {
            string answer = "";

            var _result = my_string.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));

            string _invertedResult = new String(_result.ToArray());

            answer = _invertedResult;
            return answer;

        }
    }
    class 대문자와_소문자
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "cccCCC";
            string _my_string2 = "abCdEfghIJ";

            Console.WriteLine(_solution.solution(_my_string1));
            Console.WriteLine(_solution.solution(_my_string2));
            
        }
    }
    */
}
