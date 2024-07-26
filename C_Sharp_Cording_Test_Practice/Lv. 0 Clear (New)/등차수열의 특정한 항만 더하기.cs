using System;

/* 두 정수 a, d와 길이가 n인 boolean 배열 included가 주어집니다. 
 * 
 * 첫째항이 a, 공차가 d인 등차수열에서 included[i]가 i + 1항을 의미할 때, 
 * 이 등차수열의 1항부터 n항까지 included가 true인 항들만 더한 값을 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int a, int d, bool[] included)
        {
            int answer = 0;
            for (int i = 0; i < included.Length; i++)
            {
                if (included[i])
                {
                    answer += a + i * d;
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

            bool[] _included01 = { true, false, false, true, true };
            bool[] _included02 = { false, false, false, true, false, false, false };

            Console.WriteLine(_solution.solution(3, 4, _included01));
            Console.WriteLine(_solution.solution(7, 1, _included02));
        }
    }
    */
}
