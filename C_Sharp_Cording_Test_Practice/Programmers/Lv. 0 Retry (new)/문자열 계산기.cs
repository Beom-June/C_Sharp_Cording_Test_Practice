using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * my_string은 "3 + 5"처럼 문자열로 된 수식입니다. 
 * 문자열 my_string이 매개변수로 주어질 때, 수식을 계산한 값을 
 * return 하는 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string my_string)
        {
            string[] _arr = my_string.Split(" ");   //  띄어쓰기로 구분
            int answer = 0;

            for (int i = 0; i < _arr.Length; i++)
            {
                if(_arr[i] == "+")
                {
                    answer += int.Parse(_arr[i + 1]);
                    i++;
                }
                else if (_arr[i] == "-")
                {
                    answer -= int.Parse(_arr[i + 1]);
                    i++;
                }
                else
                {
                    answer += int.Parse(_arr[i]);
                }
            }
            return answer;
        }
    }
    class 문자열_계산기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution("3 + 4"));
        }
    }
    */
}
