using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 숫자와 "Z"가 공백으로 구분되어 담긴 문자열이 주어집니다. 
 * 문자열에 있는 숫자를 차례대로 더하려고 합니다. 
 * 이 때 "Z"가 나오면 바로 전에 더했던 숫자를 뺀다는 뜻입니다. 
 * 숫자와 "Z"로 이루어진 문자열 s가 주어질 때, 
 * 머쓱이가 구한 값을 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            int _num = 0;

            string[] _elements = s.Split(' ');
            foreach (string _s in _elements)
            {
                if (_s == "Z")
                {
                    answer -= _num;
                }
                else
                {
                    _num = int.Parse(_s);
                    answer += _num;
                }
            }
            return answer;
        }
    }
    class 컨트롤_제트
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s1 = "1 2 Z 3";
            string _s2 = "10 20 30 40";
            string _s3 = "10 Z 20 Z 1";
            string _s4 = "10 Z 20 Z";
            string _s5 = "-1 -2 -3 Z";

            Console.WriteLine(_solution.solution(_s1));
            Console.WriteLine(_solution.solution(_s2));
            Console.WriteLine(_solution.solution(_s3));
            Console.WriteLine(_solution.solution(_s4));
            Console.WriteLine(_solution.solution(_s5));
        }
    }
    */
}
