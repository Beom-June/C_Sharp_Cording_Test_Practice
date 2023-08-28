using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 my_string과 두 정수 m, c가 주어집니다. 
 * my_string을 한 줄에 m 글자씩 가로로 적었을 때 왼쪽부터 
 * 세로로 c번째 열에 적힌 글자들을 문자열로 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, int m, int c)
        {
            string answer = "";
            for (int i = c - 1; i < my_string.Length; i += m)
            {
                answer += my_string[i];
            }

            return answer;
        }
    }
    class 세로_읽기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "ihrhbakrfpndopljhygc";
            string _my_string2 = "programmers";

            int _m1 = 4, _m2 = 1;
            int _c1 = 2, _c2 = 1;

            foreach (var _string in _solution.solution(_my_string1, _m1, _c1))
            {
                Console.Write(_string);
            }
            Console.WriteLine();

            foreach (var _string in _solution.solution(_my_string2, _m2, _c2))
            {
                Console.Write(_string);
            }
            Console.WriteLine();
        }
    }
    */
}
