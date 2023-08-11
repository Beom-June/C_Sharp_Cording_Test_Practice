using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 정수 a, d와 길이가 n인 boolean 배열 included가 주어집니다. 
 * 첫째항이 a, 공차가 d인 등차수열에서 included[i]가 i + 1항을 의미할 때, 
 * 이 등차수열의 1항부터 n항까지 included가 true인 항들만 더한 값을 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        // a : 첫째항, b : 공차, included : i + 1
        public int solution(int a, int d, bool[] included)
        {
            int answer = 0;

            for (int i = 0; i < included.Length; i++)
            {
                if (included[i])
                {
                    int _term = a + d * i; // 등차수열의 i+1번째 항
                    answer += _term;
                }
            }

            return answer;
        }
    }
    class 등차수열의_특정한_항만_더하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _a1 = 3, _a2 = 7;
            int _b1 = 4, _b2 = 1;
            bool[] _included1 = { true, false, false, true, true };
            bool[] _included2 = { false, false, false, true, false, false, false };

            Console.WriteLine(_solution.solution(_a1, _b1, _included1));
            Console.WriteLine(_solution.solution(_a2, _b2, _included2));
        }
    }
    */
}
