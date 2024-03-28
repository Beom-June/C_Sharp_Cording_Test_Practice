using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 문자열 s의 길이가 4 혹은 6이고, 숫자로만 구성돼있는지 
 * 확인해주는 함수, solution을 완성하세요. 
 * 예를 들어 s가 "a234"이면 False를 리턴하고 "1234"라면 True를 리턴하면 됩니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public bool solution(string s)
        {
            //bool answer = true;
            //if (s.Length == 6 || s.Length == 4)
            //{
            //    answer = int.TryParse(s, out int x);
            //}
            //return answer;

            Regex regex = new Regex(@"^(\d{4}|\d{6})$");
            return regex.IsMatch(s);
        }
    }
    class 문자열_다루기_기본
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution("a234"));
            Console.WriteLine(_solution.solution("1234"));
        }
    }
    */
}
