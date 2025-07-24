using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 알파벳 대소문자로만 이루어진 문자열 my_string이 주어질 때, 
 * my_string에서 'A'의 개수, my_string에서 'B'의 개수,..., 
 * my_string에서 'Z'의 개수, my_string에서 'a'의 개수, my_string에서 'b'의 개수,..., 
 * my_string에서 'z'의 개수를 순서대로 담은 길이 52의 정수 배열을 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(string my_string)
        {
            int[] answer = new int[52];

            foreach (var _char in my_string)
            {
                if (char.IsUpper(_char)) // 대문자인 경우
                {
                    answer[_char - 'A']++; // 'A'부터 차례로 세기 위해 'A'를 빼줌
                }
                else if (char.IsLower(_char)) // 소문자인 경우
                {
                    answer[26 + _char - 'a']++; // 'a'부터 차례로 세기 위해 'a'를 빼줌
                }
            }
            return answer;
        }
    }
    class 문자_개수_세기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string = "Programmers";

            foreach (var _string in _solution.solution(_my_string))
            {
                Console.Write(_string + ", ");
            }
            Console.WriteLine();
        }
    }
    */
}
