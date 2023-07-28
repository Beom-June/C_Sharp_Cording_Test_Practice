using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * my_string은 "3 + 5"처럼 문자열로 된 수식입니다. 
 * 문자열 my_string이 매개변수로 주어질 때, 
 * 수식을 계산한 값을 return 하는 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string my_string)
        {
            string[] _str = my_string.Split(" ");
            int answer = int.Parse(_str[0]);

            for (int i = 1; i < _str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (_str[i].Equals("+"))
                    {
                        answer += int.Parse(_str[i + 1]);
                    }
                    else
                    {
                        answer -= int.Parse(_str[i + 1]);
                    }
                }

            }
            return answer;
        }
    }
    class 문자열_계산하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string = "3 + 4";

            Console.WriteLine(_solution.solution(_my_string));
        }
    }
    */
}
