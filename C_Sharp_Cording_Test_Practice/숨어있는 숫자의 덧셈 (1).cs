using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Cording_Test_Practice
{
    public class Solution
    {
        public int solution(string my_string)
        {
            int answer = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                // IsDigit은 string에 문자가 10진수인지 판별하고 참이면 True를 반환  
                if (Char.IsDigit(my_string[i]) == true)
                {
                    answer += (int)my_string[i] - 48;
                }
            }
            return answer;
        }
    }
    class 숨어있는_숫자의_덧셈__1_
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "aAb1B2cC34oOp";
            string _my_string2 = "1a2b3c4d123";

            Console.WriteLine(_solution.solution(_my_string1));
            Console.WriteLine(_solution.solution(_my_string2));
        }
    }
}
