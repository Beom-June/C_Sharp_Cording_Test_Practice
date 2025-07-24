using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 머쓱이는 구슬을 친구들에게 나누어주려고 합니다. 
 * 구슬은 모두 다르게 생겼습니다. 
 * 
 * 머쓱이가 갖고 있는 구슬의 개수 balls와 친구들에게 나누어 줄 구슬 개수 share이 매개변수로 주어질 때, 
 * balls개의 구슬 중 share개의 구슬을 고르는 가능한 모든 경우의 수를 return 하는 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public long solution(int balls, int share)
        {
            // 최적화된 조합 계산
            if (share > balls - share)
            {
                share = balls - share; // 조합의 대칭성 사용
            }

            long result = 1;
            for (int i = 0; i < share; i++)
            {
                result *= (balls - i);    // n * (n-1) * ... * (n-k+1)
                result /= (i + 1);        // k * (k-1) * ... * 1
            }

            return result;
        }
    }
    class 구슬을_나누는_경우의_수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(3, 2));        //  3
            Console.WriteLine(_solution.solution(5, 3));        //  10
        }
    }
    */
}