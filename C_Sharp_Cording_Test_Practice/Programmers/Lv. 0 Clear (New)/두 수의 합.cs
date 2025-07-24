using System;
using System.Numerics;

/* Retry : 원래하던 Convert 방식은 숫자가 크면 불가....
 * 0 이상의 두 정수가 문자열 a, b로 주어질 때, a + b의 값을 문자열로 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string a, string b)
        {
            string answer = "";
            long _sum = 0;
            long _stringA = Convert.ToInt32(a);
            long _stringB = Convert.ToInt32(b);

            _sum = _stringA + _stringB;

            answer = Convert.ToString(_sum);
            return answer;
        }
    }
    class 두_수의_합
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _a01 = "582";
            string _a02 = "18446744073709551615";
            string _a03 = "0";

            string _b01 = "734";
            string _b02 = "287346502836570928366";
            string _b03 = "0";

            Console.WriteLine(_solution.solution(_a01, _b01));
            Console.WriteLine(_solution.solution(_a02, _b02));
            Console.WriteLine(_solution.solution(_a03, _b03));
        }
    }
    */
}