using System;

/* Retry
 * 문자열 myString과 pat가 주어집니다. 
 * 
 * myString의 부분 문자열중 pat로 끝나는 가장 긴 부분 문자열을 찾아서 
 * return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string myString, string pat)
        {
            string answer = "";
            for (int i = myString.Length - pat.Length; i >= 0; i--)
            {
                if (myString.Substring(i).StartsWith(pat))
                {
                    answer = myString.Substring(0, i + pat.Length);
                    break;
                }
            }
            return answer;
        }
    }
    class 특정_문자열로_끝나는_가장_긴_부분_문자열_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString01 = "AbCdEFG";
            string _myString02 = "AAAAaaaa";

            string _pat01 = "dE";
            string _pat02 = "a";

            Console.WriteLine(_solution.solution(_myString01, _pat01));
            Console.WriteLine(_solution.solution(_myString02, _pat02));

        }
    }
    */
}