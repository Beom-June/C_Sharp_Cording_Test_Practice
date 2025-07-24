using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 숫자로 이루어진 문자열 t와 p가 주어질 때, t에서 p와 길이가 같은 부분문자열 중에서, 
 * 이 부분문자열이 나타내는 수가 p가 나타내는 수보다 작거나 같은 것이 나오는 횟수를 return하는 
 * 함수 solution을 완성하세요.
 * 
 * 예를 들어, t="3141592"이고 p="271" 인 경우, t의 길이가 3인 부분 문자열은 314, 141, 415, 159, 592입니다. 
 * 이 문자열이 나타내는 수 중 271보다 작거나 같은 수는 141, 159 2개 입니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string t, string p)
        {
            int answer = 0;

            long _ip = long.Parse(p);

            for (int i = 0; i <= t.Length - p.Length; i++)
            {
                long _parse = long.Parse(t.Substring(i, p.Length));

                if (_parse <= _ip)
                    answer++;
            }
                return answer;
        }
    }
    class 크기가_작은_부분_문자열
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _t1 = "3141592";
            string _t2 = "500220839878";
            string _t3 = "10203";

            string _p1 = "271";
            string _p2 = "7";
            string _p3 = "15";

            Console.WriteLine(_solution.solution(_t1, _p1));
            Console.WriteLine(_solution.solution(_t2, _p2));
            Console.WriteLine(_solution.solution(_t3, _p3));
        }
    }
    */
}
