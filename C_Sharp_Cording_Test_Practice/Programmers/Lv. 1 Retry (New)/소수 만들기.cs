using System;

/* Retry
 * 주어진 숫자 중 3개의 수를 더했을 때 소수가 되는 경우의 개수를 구하려고 합니다. 
 * 숫자들이 들어있는 배열 nums가 매개변수로 주어질 때, nums에 있는 숫자들 중 
 * 서로 다른 3개를 골라 더했을 때 소수가 되는 경우의 개수를 return 하도록 solution 함수를 완성해주세요.
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

            //  3개 선택 하므로 3중
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int q = j + 1; q < nums.Length; q++)
                    {
                        bool _isPrime = true;               //  소수 체크
                        _sum = nums[i] + nums[j] + nums[q];

                        //  소수 확인. 2부터 시작
                        for (int k = 2; k * k <= _sum; k++) // _sum의 제곱근까지만 확인
                        {
                            if (_sum % k == 0) // _sum이 k로 나누어떨어지면
                            {
                                _isPrime = false; 
                                break;
                            }
                        }
                        if (_isPrime)
                            answer++;
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

            Console.WriteLine(_solution.solution(_nums01));     //  1
            Console.WriteLine(_solution.solution(_nums02));     //  4
        }
    }
    */
}