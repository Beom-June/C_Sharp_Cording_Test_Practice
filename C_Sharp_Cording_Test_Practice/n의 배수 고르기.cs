using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 n과 정수 배열 numlist가 매개변수로 주어질 때, 
 * numlist에서 n의 배수가 아닌 수들을 제거한 
 * 배열을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int n, int[] numlist)
        {
            int[] answer = new int[numlist.Length];
            List<int> _list = new List<int>();

            for (int i = 0; i < numlist.Length; i++)
            {
                if (numlist[i] % n == 0)
                {
                    _list.Add(numlist[i]);
                }
            }
            answer = _list.ToArray();

            return answer;
        }
    }
    class n의_배수_고르기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n1 = 3;
            int _n2 = 5;
            int _n3 = 12;

            int[] _numlist1 = { 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] _numlist2 = { 1, 9, 3, 10, 13, 5 };
            int[] _numlist3 = { 2, 100, 120, 600, 12, 12 };

            foreach (var _n in _solution.solution(_n1, _numlist1))
            {
                Console.Write(_n + ", ");
            }
            Console.WriteLine();

            foreach (var _n in _solution.solution(_n2, _numlist2))
            {
                Console.Write(_n + ", ");
            }
            Console.WriteLine();

            foreach (var _n in _solution.solution(_n3, _numlist3))
            {
                Console.Write(_n + ", ");
            }
            Console.WriteLine();
        }
    }
    */
}
