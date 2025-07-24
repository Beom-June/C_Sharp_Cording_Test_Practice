using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자 "A"와 "B"로 이루어진 문자열 myString과 pat가 주어집니다. 
 * myString의 "A"를 "B"로, "B"를 "A"로 바꾼 문자열의 연속하는 부분 문자열 중 
 * pat이 있으면 1을 아니면 0을 return 하는 solution 함수를 완성하세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string myString, string pat)
        {
            int answer = 0;
            string _trans = myString.Replace("A", "X").Replace("B", "A").Replace("X", "B");
            if (_trans.Contains(pat))
            {
                answer = 1;
            }
            else
            {
                answer = 0;
            }
            return answer;
        }
    }
    class 문자열_바꿔서_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString1 = "ABBAA";
            string _myString2 = "ABAB";

            string _pat1 = "AABB";
            string _pat2 = "ABAB";

            Console.WriteLine(_solution.solution(_myString1 ,_pat1));
            Console.WriteLine(_solution.solution(_myString2 ,_pat2));
        }
    }
    */
}
