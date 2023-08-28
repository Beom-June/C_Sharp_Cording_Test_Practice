using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 my_string과 정수 s, e가 매개변수로 주어질 때, 
 * my_string에서 인덱스 s부터 인덱스 e까지를 뒤집은 
 * 문자열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, int s, int e)
        {
            char[] chars = my_string.ToCharArray();

            while (s < e)
            {
                char temp = chars[s];
                chars[s] = chars[e];
                chars[e] = temp;

                s++;
                e--;
            }

            return new string(chars);
        }
    }
    class 문자열_뒤집기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "Progra21Sremm3";
            string _my_string2 = "Stanley1yelnatS";

            int _s1 = 6, _s2 = 4;
            int _e1 = 12, _e2 = 10;

            foreach (var _string in _solution.solution(_my_string1, _s1, _e1))
            {
                Console.Write(_string + "");
            }
            Console.WriteLine();

            foreach (var _string in _solution.solution(_my_string2, _s2, _e2))
            {
                Console.Write(_string + "");
            }
            Console.WriteLine();
        }
    }
    */
}
