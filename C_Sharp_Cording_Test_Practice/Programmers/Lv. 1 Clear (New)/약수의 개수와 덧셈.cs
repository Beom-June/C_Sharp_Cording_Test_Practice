using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 정수 left와 right가 매개변수로 주어집니다. 
 * left부터 right까지의 모든 수들 중에서, 약수의 개수가 짝수인 수는 더하고, 
 * 약수의 개수가 홀수인 수는 뺀 수를 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int left, int right)
        {
            int answer = 0;
            for (int i = left; i <= right; i++)
            {
                int _cnt = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        _cnt++;
                    }
                }

                if (_cnt % 2 == 0)
                    answer += i;
                else
                    answer -= i;

            }
            return answer;
        }
    }
    class 약수의_개수와_덧셈
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(13, 17));   //  43
            Console.WriteLine(_solution.solution(24, 27));   //  52
        }
    }
    */
}