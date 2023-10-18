using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * S사에서는 각 부서에 필요한 물품을 지원해 주기 위해 부서별로 물품을 구매하는데 필요한 금액을 조사했습니다. 
 * 그러나, 전체 예산이 정해져 있기 때문에 모든 부서의 물품을 구매해 줄 수는 없습니다. 
 * 그래서 최대한 많은 부서의 물품을 구매해 줄 수 있도록 하려고 합니다.
 * 
 * 물품을 구매해 줄 때는 각 부서가 신청한 금액만큼을 모두 지원해 줘야 합니다. 
 * 예를 들어 1,000원을 신청한 부서에는 정확히 1,000원을 지원해야 하며, 
 * 1,000원보다 적은 금액을 지원해 줄 수는 없습니다.
 * 
 * 부서별로 신청한 금액이 들어있는 배열 d와 예산 budget이 매개변수로 주어질 때, 
 * 최대 몇 개의 부서에 물품을 지원할 수 있는지 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] d, int budget)
        {
            // 부서가 신청한 금액을 오름차순으로 정렬
            Array.Sort(d);

            int answer = 0;
            int _remainingBudget = budget;

            // 부서의 신청 금액이 예산을 초과하지 않는 동안 지원 가능한 부서 수를 카운트
            foreach (var _request in d)
            {
                if (_remainingBudget - _request >= 0)
                {
                    _remainingBudget -= _request;
                    answer++;
                }
                else
                {
                    break; // 더 이상 지원할 수 없는 경우 반복문 종료
                }
            }

            return answer;
        }
    }
    class 예산
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _d1 = { 1, 3, 2, 5, 4 };
            int[] _d2 = { 2, 2, 3, 3 };

            int _budget1 = 9, _budget2 = 10;

            Console.WriteLine(_solution.solution(_d1, _budget1));
            Console.WriteLine(_solution.solution(_d2, _budget2));
        }
    }
    */
}
