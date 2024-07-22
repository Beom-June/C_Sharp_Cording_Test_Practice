using System;

/* Retry
 * 정수로 이루어진 문자열 n_str이 주어질 때, 
 * n_str의 가장 왼쪽에 처음으로 등장하는 0들을 뗀 문자열을 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice.Lv._0_Retry__new_
{
    /*
    public class Solution
    {
        public string solution(string n_str)
        {
            // 문자열의 시작 부분에서 '0'을 모두 제거합니다.
            string answer = n_str.TrimStart('0');
            // 만약 모든 문자가 '0'이었다면, 빈 문자열 대신 "0"을 반환합니다.
            return string.IsNullOrEmpty(answer) ? "0" : answer;
        }
    }
    class _0_떼기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _nStr01 = "0010";
            string _nStr02 = "854020";

            Console.WriteLine(_solution.solution(_nStr01));     //  10
            Console.WriteLine(_solution.solution(_nStr02));     //  854020
        }
    }
    */
}