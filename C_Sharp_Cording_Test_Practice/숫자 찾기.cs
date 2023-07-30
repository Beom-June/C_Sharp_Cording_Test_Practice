using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 num과 k가 매개변수로 주어질 때, 
 * num을 이루는 숫자 중에 k가 있으면 num의 그 숫자가 있는 자리 수를 
 * return하고 없으면 -1을 return 하도록 solution 함수를 완성해보세요
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int num, int k)
        {
            int answer = 0;

            // num 정수를 string으로 변환
            string _numStr = num.ToString();

            // 찾기
            int _idx = _numStr.IndexOf(k.ToString());

            if (_idx != -1)
            {
                answer = _idx + 1;
            }
            else
            {
                answer = -1;
            }
            return answer;
        }
    }
    class 숫자_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _num1 = 29183;
            int _num2 = 232443;
            int _num3 = 123456;

            int _k1 = 1;
            int _k2 = 4;
            int _k3 = 7;

            Console.WriteLine(_solution.solution(_num1, _k1));
            Console.WriteLine(_solution.solution(_num2, _k2));
            Console.WriteLine(_solution.solution(_num3, _k3));
        }
    }
    */
}
