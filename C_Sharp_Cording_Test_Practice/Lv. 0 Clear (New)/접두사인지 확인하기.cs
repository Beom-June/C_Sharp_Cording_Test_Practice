using System;

/* 어떤 문자열에 대해서 접두사는 특정 인덱스까지의 문자열을 의미합니다. 
 * 예를 들어, "banana"의 모든 접두사는 "b", "ba", "ban", "bana", "banan", "banana"입니다.
 * 
 * 문자열 my_string과 is_prefix가 주어질 때, 
 * is_prefix가 my_string의 접두사라면 1을, 
 * 아니면 0을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string my_string, string is_prefix)
        {
            int answer = 0;
            answer = my_string.StartsWith(is_prefix) ? 1 : 0;
            return answer;
        }
    }
    class 접두사인지_확인하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString = "banana";
            string _isPrefix01 = "ban";
            string _isPrefix02 = "nan";
            string _isPrefix03 = "abcd";
            string _isPrefix04 = "bananan";

            Console.WriteLine(_solution.solution(_myString, _isPrefix01));
            Console.WriteLine(_solution.solution(_myString, _isPrefix02));
            Console.WriteLine(_solution.solution(_myString, _isPrefix03));
            Console.WriteLine(_solution.solution(_myString, _isPrefix04));
        }
    }
    */
}
