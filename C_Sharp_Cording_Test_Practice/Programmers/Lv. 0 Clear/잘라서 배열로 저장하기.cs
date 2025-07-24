using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 my_str과 n이 매개변수로 주어질 때, 
 * my_str을 길이 n씩 잘라서 저장한 배열을 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string my_str, int n)
        {
            string[] answer = new string[my_str.Length];
            int _cnt = 0;

            if (my_str.Length % n == 0)
            {
                answer = new string[my_str.Length / n];
            }
            else
            {
                answer = new string[my_str.Length / n + 1];
            }

            for (int i = 0; i < my_str.Length; i++)
            {
                answer[_cnt] += my_str[i];
                if ((i + 1) % n == 0)
                {
                    _cnt++;
                }
            }
            return answer;
        }
    }
    class 잘라서_배열로_저장하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_str_1 = "abc1Addfggg4556b";
            string _my_str_2 = "abcdef123";

            int _n1 = 6;
            int _n2 = 3;

            foreach (var _str in _solution.solution(_my_str_1, _n1))
            {
                Console.Write(_str + " ");
            }
            Console.WriteLine();

            foreach (var _str in _solution.solution(_my_str_2, _n2))
            {
                Console.Write(_str + " ");
            }
            Console.WriteLine();
        }
    }
*/
}
