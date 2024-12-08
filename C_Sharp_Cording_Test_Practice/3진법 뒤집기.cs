using System;

/* 자연수 n이 매개변수로 주어집니다. n을 3진법 상에서 앞뒤로 뒤집은 후, 
 * 이를 다시 10진법으로 표현한 수를 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int n)
        {
            string _binary = "";
            while (n > 0)
            {
                _binary += (n % 3);
                n /= 3;
            }

            // 10진법으로 변환
            int answer = 0;
            for (int i = 0; i < _binary.Length; i++)
            {
                answer = answer * 3 + (_binary[i] - '0');
            }

            return answer;
        }
    }
    class _3진법_뒤집기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(45));      //  7
            Console.WriteLine(_solution.solution(125));     //  229
        }
    }
    */
}