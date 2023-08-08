using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 my_string이 매개변수로 주어집니다.
 * my_string은 소문자, 대문자, 자연수로만 구성되어있습니다. 
 * my_string안의 자연수들의 합을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string my_string)
        {
            int answer = 0;
            int _currentNum = 0;

            for (int i = 0; i < my_string.Length; i++)
            {
                char _c = my_string[i];

                // _c 가 숫자인지 판별
                if (char.IsDigit(_c))
                {
                    // 현재 찾고 있는 자연수를 누적
                    _currentNum = _currentNum * 10 + (_c - '0');
                }
                else
                {
                    answer += _currentNum;
                    _currentNum = 0;
                }
            }
            answer += _currentNum;

            return answer;
        }
    }
    class 숨어있는_숫자의_덧셈__2_
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string = "aAb1B2cC34oOp";
            Console.WriteLine(_solution.solution(_my_string));
        }
    }
    */
}
