using System;

/* 음이 아닌 정수를 9로 나눈 나머지는 그 정수의 각 자리 숫자의 합을 9로 나눈 나머지와 같은 것이 알려져 있습니다.
 * 
 * 이 사실을 이용하여 음이 아닌 정수가 문자열 number로 주어질 때, 
 * 이 정수를 9로 나눈 나머지를 return 하는 solution 함수를 작성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string number)
        {
            int answer = 0;
            foreach (var c in number)
            {
                //  각 자리의 숫자의 합을 계산
                answer += c - '0';
            }
            answer %= 9;
            return answer;
        }
    }
    class _9로_나눈_나머지
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();


            Console.WriteLine(_solution.solution("123"));                   //  6
            Console.WriteLine(_solution.solution("78720646226947352489"));  //  2
        }
    }
    */
}