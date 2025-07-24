using System;

/* Retry
 * 한 개 이상의 항의 합으로 이루어진 식을 다항식이라고 합니다. 
 * 다항식을 계산할 때는 동류항끼리 계산해 정리합니다. 
 * 
 * 덧셈으로 이루어진 다항식 polynomial이 매개변수로 주어질 때, 
 * 동류항끼리 더한 결괏값을 문자열로 return 하도록 solution 함수를 완성해보세요. 
 * 같은 식이라면 가장 짧은 수식을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string polynomial)
        {
            // 다항식을 공백과 '+'를 기준으로 분리
            var _terms = polynomial.Split(" + ");

            int _xCount = 0;  // x항의 계수
            int _constant = 0; // 상수항

            foreach (var term in _terms)
            {
                if (term.Contains("x"))
                {
                    // x항인 경우
                    if (term == "x")
                    {
                        _xCount += 1;  // 'x'는 1x로 처리
                    }
                    else
                    {
                        _xCount += int.Parse(term.Replace("x", ""));
                    }
                }
                else
                {
                    // 상수항인 경우
                    _constant += int.Parse(term);
                }
            }

            // 결과 문자열 조립
            string _result = "";

            if (_xCount != 0)
            {
                _result += _xCount == 1 ? "x" : _xCount + "x";
            }

            if (_constant != 0)
            {
                _result += (_xCount != 0 ? " + " : "") + _constant;
            }

            return _result == "" ? "0" : _result;
        }
    }
    class 다항식_더하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _polynomial01 = "3x + 7 + x";
            string _polynomial02 = "x + x + x";

            //  4x + 7
            foreach (var s in _solution.solution(_polynomial01))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            //  3x
            foreach (var s in _solution.solution(_polynomial02))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
    */
}