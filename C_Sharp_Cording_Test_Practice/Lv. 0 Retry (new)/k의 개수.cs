using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
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
            string _kStr = k.ToString();

            for (int num = i; num <= j; num++)
            {
                string _numStr = num.ToString();
                foreach (char c in _numStr)
                {
                    if (c.ToString() == _kStr)
                    {
                        answer++;
                    }
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

            Console.WriteLine(_solution.solution(1, 13, 1));        //  6
            Console.WriteLine(_solution.solution(10, 50, 5));       //  5
            Console.WriteLine(_solution.solution(3, 10, 2));        //  0
        }
    }
    */
}