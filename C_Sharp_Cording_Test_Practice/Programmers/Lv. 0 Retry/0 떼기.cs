using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수로 이루어진 문자열 n_str이 주어질 때,
 * n_str의 가장 왼쪽에 처음으로 등장하는 0들을 뗀 문자열을 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string n_str)
        {
            string answer = "";

            // 문자열을 처음부터 순회하면서 0이 아닌 문자가 나올 때부터 결과에 추가
            bool _flag = false;
            foreach (char _c in n_str)
            {
                if (_c != '0' || _flag)
                {
                    answer += _c;
                    _flag = true;
                }
            }

            // 모든 문자가 0일 경우 하나의 '0'을 반환
            if (string.IsNullOrEmpty(answer))
            {
                return "0";
            }

            return answer;
        }
    }
    class _0_떼기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _n_str1 = "0010";
            string _n_str2 = "854020";

            Console.WriteLine(_solution.solution(_n_str1));
            Console.WriteLine(_solution.solution(_n_str2));
        }
    }
    */
}
