using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 0과 1로 이루어진 어떤 문자열 x에 대한 이진 변환을 다음과 같이 정의합니다.
 * 
 * x의 모든 0을 제거합니다.
 * x의 길이를 c라고 하면, x를 "c를 2진법으로 표현한 문자열"로 바꿉니다.
 * 예를 들어, x = "0111010"이라면, x에 이진 변환을 가하면 
 * x = "0111010" -> "1111" -> "100" 이 됩니다.
 * 
 * 0과 1로 이루어진 문자열 s가 매개변수로 주어집니다. 
 * s가 "1"이 될 때까지 계속해서 s에 이진 변환을 가했을 때, 
 * 이진 변환의 횟수와 변환 과정에서 제거된 모든 0의 개수를 
 * 각각 배열에 담아 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(string s)
        {
            int[] answer = new int[] { 0, 0 };

            while (!s.Equals("1"))
            {
                answer[0]++;
                var _OneCharCount = s.Where(x => x.Equals('1')).Count();
                answer[1] += s.Length - _OneCharCount;

                s = Convert.ToString(_OneCharCount, 2);
            }

            return answer;
        }
    }
    class 이진_변환_반복하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s1 = "110010101001";
            string _s2 = "01110";
            string _s3 = "1111111";

            Console.WriteLine(String.Join(", " ,_solution.solution(_s1)));     //  3,8
            Console.WriteLine(String.Join(", ", _solution.solution(_s2)));     //  3,3
            Console.WriteLine(String.Join(", ", _solution.solution(_s3)));     //  4,1
        }
    }
 */
}