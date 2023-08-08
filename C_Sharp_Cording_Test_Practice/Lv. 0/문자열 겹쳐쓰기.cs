using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 my_string, overwrite_string과 정수 s가 주어집니다. 
 * 문자열 my_string의 인덱스 s부터 overwrite_string의 길이만큼을 
 * 문자열 overwrite_string으로 바꾼 문자열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, string overwrite_string, int s)
        {
            string answer = "";

            string _str = my_string.Substring(0, s);
            string _overlap = my_string.Substring(overwrite_string.Length +s);
            answer = _str + overwrite_string + _overlap;

            return answer;
        }
    }
    class 문자열_겹쳐쓰기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "He11oWor1d";
            string _overwrite_string1 = "lloWorl";
            int _s1 = 2;

            Console.WriteLine(_solution.solution(_my_string1, _overwrite_string1, _s1));
        }
    }
    */
}
