using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 영어에선 a, e, i, o, u 다섯 가지 알파벳을 모음으로 분류합니다. 
 * 문자열 my_string이 매개변수로 주어질 때 모음을 제거한 문자열을 
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
            string[] _array = my_string.Split('a', 'e', 'i', 'o', 'u') ;
            for (int i = 0; i < _array.Length; i++)
            {
                answer += _array[i];
            }
            return answer;
        }
    }
    class 모음_제거
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "bus";
            string _my_string2 = "nice to meet you";

            foreach (var _string1 in _solution.solution(_my_string1))
            {
                Console.Write(_string1 + "");
            }
            Console.WriteLine();

            foreach (var _string2 in _solution.solution(_my_string2))
            {
                Console.Write(_string2 + "");
            }
            Console.WriteLine();
        }
    }
    */
}
