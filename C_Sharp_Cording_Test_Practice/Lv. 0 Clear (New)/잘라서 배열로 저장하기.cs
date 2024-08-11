using System;
using System.Collections.Generic;

/* 문자열 my_str과 n이 매개변수로 주어질 때, 
 * my_str을 길이 n씩 잘라서 저장한 배열을 return하도록 solution 함수를 완성해주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string my_str, int n)
        {
            List<string> answer = new List<string>();

            for (int i = 0; i < my_str.Length; i += n)
            {
                if (i + n <= my_str.Length)
                    answer.Add(my_str.Substring(i, n));
                else
                    answer.Add(my_str.Substring(i));
            }

            return answer.ToArray();
        }
    }
    class 잘라서_배열로_저장하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myStr01 = "abc1Addfggg4556b";
            string _myStr02 = "abcdef123";

            foreach (var s in _solution.solution(_myStr01, 6))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            foreach (var s in _solution.solution(_myStr02, 3))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
    */
}