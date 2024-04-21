using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 1부터 입력받은 숫자 n 사이에 있는 소수의 개수를 반환하는 함수, solution을 만들어 보세요.
 * 소수는 1과 자기 자신으로만 나누어지는 수를 의미합니다.
 * (1은 소수가 아닙니다.)
 */
namespace C_Sharp_Cording_Test_Practice
{

    /*
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 2; i <= n; i++)
            {
                if (isPrime(i))
                    answer++;
            }
            return answer;
        }
        //  제곱근 이용
        public bool isPrime(int n)
        {
            int _nr = (int)Math.Sqrt(n);
            for (int i = 2; i <= _nr; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
    class 소수_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(10));
            Console.WriteLine(_solution.solution(5));
        }
    }
    */
}