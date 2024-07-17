using System;

/* Retry
 * 문자열 myString이 주어집니다. 
 * 
 * myString에서 알파벳 "a"가 등장하면 전부 "A"로 변환하고, 
 * "A"가 아닌 모든 대문자 알파벳은 소문자 알파벳으로 변환하여 
 * return 하는 solution 함수를 완성하세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string myString)
        {
            string _temp = myString.Replace('a', 'A');

            string answer = "";
            //  생각은 했으나 이 밑 부분 부터 구현 못함
            foreach (char c in _temp)
            {
                if (c == 'A')
                {
                    answer += 'A';
                }
                else if (char.IsUpper(c))
                {
                    answer += char.ToLower(c);
                }
                else
                {
                    answer += c;
                }
            }
            return answer;
        }
    }
    class A_강조하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString01 = "abstract algebra";
            string _myString02 = "PrOgRaMmErS";

            Console.WriteLine(_solution.solution(_myString01));
            Console.WriteLine(_solution.solution(_myString02));
        }
    }
    */
}