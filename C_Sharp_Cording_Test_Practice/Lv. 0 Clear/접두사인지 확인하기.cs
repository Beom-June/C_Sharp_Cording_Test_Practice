using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 어떤 문자열에 대해서 접두사는 특정 인덱스까지의 문자열을 의미합니다. 
 * 예를 들어, "banana"의 모든 접두사는 "b", "ba", "ban", "bana", "banan", "banana"입니다.
 * 
 * 문자열 my_string과 is_prefix가 주어질 때, is_prefix가 my_string의 접두사라면 1을, 
 * 아니면 0을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string my_string, string is_prefix)
        {
            int answer = 0;
            if (is_prefix.Length <= my_string.Length)
            {
                string _prefix = my_string.Substring(0, is_prefix.Length);
                if (_prefix == is_prefix)
                {
                    answer = 1;
                }
            }
            return answer;
        }
    }
    class 접두사인지_확인하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string = "banana";

            string _is_prefix1 = "ban";
            string _is_prefix2 = "nan";
            string _is_prefix3 = "abcd";
            string _is_prefix4 = "bananan";

            Console.WriteLine(_solution.solution(_my_string, _is_prefix1));
            Console.WriteLine(_solution.solution(_my_string, _is_prefix2));
            Console.WriteLine(_solution.solution(_my_string, _is_prefix3));
            Console.WriteLine(_solution.solution(_my_string, _is_prefix4));
        }
    }
    */
}
