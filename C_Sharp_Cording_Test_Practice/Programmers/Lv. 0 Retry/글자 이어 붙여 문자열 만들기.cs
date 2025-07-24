using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 my_string과 정수 배열 index_list가 매개변수로 주어집니다.
 * my_string의 index_list의 원소들에 해당하는 인덱스의 글자들을 
 * 순서대로 이어 붙인 문자열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, int[] index_list)
        {
            string answer = "";

            foreach (int index in index_list)
            {
                if (index >= 0 && index < my_string.Length)
                {
                    answer += my_string[index];
                }
            }
            return answer;
        }
    }
    class 글자_이어_붙여_문자열_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "cvsgiorszzzmrpaqpe";
            string _my_string2 = "zpiaz";

            int[] _index_list1 = { 16, 6, 5, 3, 12, 14, 11, 11, 17, 12, 7 };
            int[] _index_list2 = { 1, 2, 0, 0, 3 };

            Console.WriteLine(_solution.solution(_my_string1, _index_list1));
            Console.WriteLine(_solution.solution(_my_string2, _index_list2));
        }
    }
    */
}
