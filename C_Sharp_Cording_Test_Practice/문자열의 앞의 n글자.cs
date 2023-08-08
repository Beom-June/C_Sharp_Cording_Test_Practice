using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 my_string과 정수 n이 매개변수로 주어질 때, 
 * my_string의 앞의 n글자로 이루어진 문자열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    public class Solution
    {
        public string solution(string my_string, int n)
        {
            string answer = "";
            return answer;
        }
    }
    class 문자열의_앞의_n글자
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "ProgrammerS123";
            string _my_string2 = "He110W0r1d";

            int _n1 = 11;
            int _n2 = 5;

            Console.WriteLine(_solution.solution(_my_string1, _n1));
            Console.WriteLine(_solution.solution(_my_string2, _n2));
        }
    }
}
