using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 영소문자로 이루어진 문자열 my_string과 영소문자 1글자로 이루어진 문자열 alp가 
 * 매개변수로 주어질 때, my_string에서 alp에 해당하는 모든 글자를 
 * 대문자로 바꾼 문자열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, string alp)
        {
            string answer = "";
            foreach (char _char in my_string)
            {
                if (_char.ToString() == alp)
                {
                    answer += _char.ToString().ToUpper();
                }
                else
                {
                    answer += _char;
                }
            }
            return answer;
        }
    }
    class 특정한_문자를_대문자로_바꾸기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "programmers";
            string _my_string2 = "lowercase";

            string _alp1 = "p";
            string _alp2 = "x";

            Console.WriteLine(_solution.solution(_my_string1, _alp1));
            Console.WriteLine(_solution.solution(_my_string2, _alp2));
        }
    }
    */
}
