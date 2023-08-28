using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 어떤 문자열에 대해서 접미사는 특정 인덱스부터 시작하는 문자열을 의미합니다. 
 * 예를 들어, "banana"의 모든 접미사는 "banana", "anana", "nana", "ana", "na", "a"입니다.
 * 
 * 문자열 my_string이 매개변수로 주어질 때, my_string의 모든 접미사를 사전순으로 
 * 정렬한 문자열 배열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string my_string)
        {
            string[] answer = new string[my_string.Length];

            for (int i = 0; i < my_string.Length; i++)
            {
                answer[i] = my_string.Substring(i); // 접미사 추출
            }
            Array.Sort(answer); // 사전순으로 정렬
            return answer;
        }
    }
    class 접미사_배열
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "banana";
            string _my_string2 = "programmers";

            foreach (var _string in _solution.solution(_my_string1))
            {
                Console.Write(_string + " ");
            }
            Console.WriteLine();

            foreach (var _string in _solution.solution(_my_string2))
            {
                Console.Write(_string + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
