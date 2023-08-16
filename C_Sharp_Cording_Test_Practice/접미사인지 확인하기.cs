using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 어떤 문자열에 대해서 접미사는 특정 인덱스부터 시작하는 문자열을 의미합니다. 
 * 예를 들어, "banana"의 모든 접미사는 "banana", "anana", "nana", "ana", "na", "a"입니다.
 * 
 * 문자열 my_string과 is_suffix가 주어질 때, 
 * is_suffix가 my_string의 접미사라면 1을, 
 * 아니면 0을 return 하는 solution 함수를 작성해 주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string my_string, string is_suffix)
        {
            int answer = 0;

            if (is_suffix.Length <= my_string.Length)
            {
                string _suffix = my_string.Substring(my_string.Length - is_suffix.Length);
                if (_suffix == is_suffix)
                {
                    answer = 1;
                }
            }

            return answer;
        }
    }
    class 접미사인지_확인하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string = "banana";

            string _is_suffix1 = "ana";
            string _is_suffix2 = "nan";
            string _is_suffix3 = "wxyz";
            string _is_suffix4 = "abanana";

            Console.WriteLine(_solution.solution(_my_string, _is_suffix1));
            Console.WriteLine(_solution.solution(_my_string, _is_suffix2));
            Console.WriteLine(_solution.solution(_my_string, _is_suffix3));
            Console.WriteLine(_solution.solution(_my_string, _is_suffix4));
        }
    }
    */
}
