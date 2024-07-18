using System;

/* 어떤 문자열에 대해서 접미사는 특정 인덱스부터 시작하는 문자열을 의미합니다. 
 * 예를 들어, "banana"의 모든 접미사는 "banana", "anana", "nana", "ana", "na", "a"입니다.
 * 
 * 문자열 my_string과 is_suffix가 주어질 때, 
 * is_suffix가 my_string의 접미사라면 1을, 
 * 아니면 0을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string my_string, string is_suffix)
        {
            int answer = 0;
            answer = my_string.EndsWith(is_suffix) ? 1 : 0;
            return answer;
        }
    }
    class 접미사인지_확인하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString = "banana";

            string _isSuffix01 = "ana";
            string _isSuffix02 = "nan";
            string _isSuffix03 = "wxyz";
            string _isSuffix04 = "abanana";

            Console.WriteLine(_solution.solution(_myString, _isSuffix01));
            Console.WriteLine(_solution.solution(_myString, _isSuffix02));
            Console.WriteLine(_solution.solution(_myString, _isSuffix03));
            Console.WriteLine(_solution.solution(_myString, _isSuffix04));
        }
    }
    */
}