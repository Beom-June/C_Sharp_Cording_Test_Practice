using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 자연수 N이 주어지면, N의 각 자릿수의 합을 구해서 
 * return 하는 solution 함수를 만들어 주세요.
 * 
 * 예를들어 N = 123이면 1 + 2 + 3 = 6을 return 하면 됩니다.
 * 
 * 제한사항
 * N의 범위 : 100,000,000 이하의 자연수
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            string _num = n.ToString();

            for (int i = 0; i < _num.Length; i++)
            {
                answer += int.Parse(_num[i].ToString());
            }

            return answer;
        }
    }
    class 자릿수_더하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n1 = 123, _n2 = 987;

            Console.WriteLine(_solution.solution(_n1));
            Console.WriteLine(_solution.solution(_n2));
        }
    }
    */
}
