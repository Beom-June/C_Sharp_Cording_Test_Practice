using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 n이 매개변수로 주어질 때, n의 약수를 오름차순으로 
 * 담은 배열을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int n)
        {
            List<int> _list = new List<int>();

            // n이 0인 경우 예외 처리
            if (n == 0)
                return _list.ToArray();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    _list.Add(i);
            }

            return _list.ToArray();
        }
    }
    class 약수_구하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n1 = 24;
            int _n2 = 29;

            foreach (var _n in _solution.solution(_n1))
            {
                Console.Write(_n + " ");
            }
            Console.WriteLine();

            foreach (var _n in _solution.solution(_n2))
            {
                Console.Write(_n + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
