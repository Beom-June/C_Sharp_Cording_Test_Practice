using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/* 복습
 * 0 이상의 두 정수가 문자열 a, b로 주어질 때, 
 * a + b의 값을 문자열로 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string a, string b)
        {
            int _maxLength = Math.Max(a.Length, b.Length);
            char[] _result = new char[_maxLength + 1];
            int _carry = 0;

            for (int i = 0; i <= _maxLength; i++)
            {
                int _digitA = (i < a.Length) ? (a[a.Length - 1 - i] - '0') : 0;
                int _digitB = (i < b.Length) ? (b[b.Length - 1 - i] - '0') : 0;
                int _sum = _digitA + _digitB + _carry;

                _carry = _sum / 10;
                _result[_maxLength - i] = (char)((_sum % 10) + '0');
            }

            if (_result[0] == '0')
            {
                return new string(_result, 1, _maxLength);
            }
            else
            {
                return new string(_result);
            }
        }
    }
    class 두_수의_합
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _a1 = "582";
            string _a2 = "18446744073709551615";
            string _a3 = "0";

            string _b1 = "734";
            string _b2 = "287346502836570928366";
            string _b3 = "0";

            Console.WriteLine(_solution.solution(_a1, _b1));    // 1316
            Console.WriteLine(_solution.solution(_a2, _b2));    // 305793246910280479981
            Console.WriteLine(_solution.solution(_a3, _b3));    // 0
        }
    }
    */
}
