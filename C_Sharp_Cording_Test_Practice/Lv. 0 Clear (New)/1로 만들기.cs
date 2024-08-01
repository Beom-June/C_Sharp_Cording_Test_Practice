using System;

/* 정수가 있을 때, 짝수라면 반으로 나누고, 홀수라면 1을 뺀 뒤 반으로 나누면, 
 * 마지막엔 1이 됩니다. 예를 들어 10이 있다면 다음과 같은 과정으로 1이 됩니다.
 * 
 * 10 / 2 = 5
 * (5 - 1) / 2 = 2
 * 2 / 2 = 1
 * 위와 같이 3번의 나누기 연산으로 1이 되었습니다.
 * 
 * 정수들이 담긴 리스트 num_list가 주어질 때, num_list의 모든 원소를 1로 만들기 위해서 
 * 필요한 나누기 연산의 횟수를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;
            foreach (var num in num_list)
            {
                // 원본 배열의 값을 변경하지 않기 위해 _current 변수 사용
                int _current = num;
                while (_current > 1)
                {
                    //  짝수면
                    if (_current % 2 == 0)
                    {
                        _current /= 2;
                    }
                    //  홀수면
                    else
                    {
                        _current = (_current - 1) / 2;
                    }
                    answer++;
                }
            }
            return answer;
        }
    }
    class _1로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numList = { 12, 4, 15, 1, 14 };
            Console.WriteLine(_solution.solution(_numList));        //  11
        }
    }
    */
}