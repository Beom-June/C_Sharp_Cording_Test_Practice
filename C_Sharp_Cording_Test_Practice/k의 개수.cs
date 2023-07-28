using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 1부터 13까지의 수에서, 1은 1, 10, 11, 12, 13 이렇게 총 6번 등장합니다. 
 * 정수 i, j, k가 매개변수로 주어질 때, i부터 j까지 k가 몇 번 등장하는지 
 * return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int i, int j, int k)
        {
            int answer = 0;
            for (; i <= j; i++)
            {
                foreach (char _c in i.ToString())
                {
                    if (_c - 48 == k)
                        answer++;
                }
            }
            return answer;
        }
    }
    class k의_개수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _i1 = 1;
            int _i2 = 10;
            int _i3 = 3;

            int _j1 = 13;
            int _j2 = 50;
            int _j3 = 10;

            int _k1 = 1;
            int _k2 = 5;
            int _k3 = 2;

            Console.WriteLine(_solution.solution(_i1, _j1, _k1));
            Console.WriteLine(_solution.solution(_i2, _j2, _k2));
            Console.WriteLine(_solution.solution(_i3, _j3, _k3));
        }
    }
    */
}
