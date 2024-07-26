using System;

/* 약수의 개수가 세 개 이상인 수를 합성수라고 합니다. 
 * 
 * 자연수 n이 매개변수로 주어질 때 n이하의 합성수의 개수를 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                int _cnt = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        _cnt++;
                    }
                }
                if (_cnt >= 3)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
    class 합성수_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(10));
            Console.WriteLine(_solution.solution(15));
        }
    }
    */
}