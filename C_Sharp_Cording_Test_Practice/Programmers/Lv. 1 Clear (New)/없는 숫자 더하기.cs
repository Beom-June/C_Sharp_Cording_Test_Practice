using System;
using System.Linq;

/* 0부터 9까지의 숫자 중 일부가 들어있는 정수 배열 numbers가 매개변수로 주어집니다. 
 * numbers에서 찾을 수 없는 0부터 9까지의 숫자를 모두 찾아 더한 수를 
 * return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] numbers)
        {
            int answer = 0;
            for (int i = 1; i <= 9; i++)
            {
                answer += i;
            }
            answer -= numbers.Sum();
            return answer;
        }
    }
    class 없는_숫자_더하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers01 = { 1, 2, 3, 4, 6, 7, 8, 0 };
            int[] _numbers02 = { 5, 8, 4, 0, 6, 7, 9 };

            Console.WriteLine(_solution.solution(_numbers01));      //  14
            Console.WriteLine(_solution.solution(_numbers02));      //  6
        }
    }
    */
}