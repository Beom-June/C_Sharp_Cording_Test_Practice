using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 주어진 숫자 중 3개의 수를 더했을 때 소수가 되는 경우의 개수를 구하려고 합니다. 
 * 숫자들이 들어있는 배열 nums가 매개변수로 주어질 때, 
 * nums에 있는 숫자들 중 서로 다른 3개를 골라 더했을 때 소수가 되는 경우의 
 * 개수를 return 하도록 solution 함수를 완성해주세요.
 * 
 * 제한사항
 * nums에 들어있는 숫자의 개수는 3개 이상 50개 이하입니다.
 * nums의 각 원소는 1 이상 1,000 이하의 자연수이며, 중복된 숫자가 들어있지 않습니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class Solution
    {
        public int solution(int[] nums)
        {
            int answer = 0;
            int _sum = 0;

            //  순차적으로 증가
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int q = j + 1; q < nums.Length; q++)
                    {
                        //  3개의 수를 더함
                        _sum = nums[i] + nums[j] + nums[q];

                        //  더한 수가 소수인지 확인
                        bool _isPrime = true;

                        for (int k = 2; k < _sum; k++)
                        {
                            // 더한 수가 2부터 자기 자신보다 작은 수까지의 수
                            // 중에서 나누어 떨어지는지 확인
                            if (_sum % k == 0)
                            {
                                _isPrime = false; // 소수가 아니면 false로 변경하고 반복문 종료
                                break;
                            }
                        }

                        // 소수인 경우 answer를 증가시킴
                        if (_isPrime)
                        {
                            answer++;
                        }
                    }
                }
            }

            return answer;
        }
    }
    class 소수_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _nums01 = { 1, 2, 3, 4 };
            int[] _nums02 = { 1, 2, 7, 6, 4 };

            Console.WriteLine(_solution.solution(_nums01));
            Console.WriteLine(_solution.solution(_nums02));
        }
    }
    */
}