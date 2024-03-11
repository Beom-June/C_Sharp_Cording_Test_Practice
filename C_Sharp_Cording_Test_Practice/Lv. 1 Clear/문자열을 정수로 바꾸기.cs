using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 s를 숫자로 변환한 결과를 반환하는 함수, solution을 완성하세요.
 * 
 * 제한 조건
 * s의 길이는 1 이상 5이하입니다.
 * s의 맨앞에는 부호(+, -)가 올 수 있습니다.
 * s는 부호와 숫자로만 이루어져있습니다.
 * s는 "0"으로 시작하지 않습니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            int _sign = 1; // 부호를 기억하는 변수, 기본값은 양수

            if (s[0] == '-')
            {
                _sign = -1;
                s = s.Substring(1);
            }
            else if (s[0] == '+')
            {
                s = s.Substring(1);
            }

            // 추출된 문자열을 정수로 변환
            answer = int.Parse(s) * _sign;

            return answer;
        }
    }
    class 문자열을_정수로_바꾸기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();
        }
    }
    */
}
