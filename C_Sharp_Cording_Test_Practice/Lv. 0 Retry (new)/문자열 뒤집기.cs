using System;

/* Retry
 * 문자열 my_string과 정수 s, e가 매개변수로 주어질 때, 
 * my_string에서 인덱스 s부터 인덱스 e까지를 뒤집은 문자열을 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, int s, int e)
        {
            // 앞부분 (s 이전)
            string _front = my_string.Substring(0, s);

            // 중간부분 (s부터 e까지) 및 뒤집기
            //  ToCharArray() : 문자 배열로 변환
            char[] _middle = my_string.Substring(s, e - s + 1).ToCharArray();
            Array.Reverse(_middle);

            // 뒷부분 (e 이후)
            string _endPart = my_string.Substring(e + 1);

            // 세 부분을 합치기
            string answer = _front + new string(_middle) + _endPart;
            return answer;
        }
    }
    class 문자열_뒤집기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString01 = "Progra21Sremm3";
            string _myString02 = "Stanley1yelnatS";

            Console.WriteLine(_solution.solution(_myString01, 6, 12));
            Console.WriteLine(_solution.solution(_myString02, 4, 10));
        }
    }
    */
}