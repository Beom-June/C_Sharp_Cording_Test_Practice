using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 약수의 개수가 세 개 이상인 수를 합성수라고 합니다. 
 * 자연수 n이 매개변수로 주어질 때 n이하의 
 * 합성수의 개수를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            int _cnt = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        _cnt++;
                }
                // _cnt 가 3개 이상이면 answer에 추가
                if (_cnt >= 3)
                    answer++;
                _cnt = 0;
            }
            return answer;
        }
    }
    class 합성수_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n1 = 10;
            int _n2 = 15;

            Console.WriteLine(_solution.solution(_n1));
            Console.WriteLine(_solution.solution(_n2));
        }
    }
    */
}
