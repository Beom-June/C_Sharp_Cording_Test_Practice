using System;

/* 정수 리스트 num_list가 주어집니다. 
 * 
 * 가장 첫 번째 원소를 1번 원소라고 할 때, 
 * 홀수 번째 원소들의 합과 짝수 번째 원소들의 합 중 큰 값을 
 * return 하도록 solution 함수를 완성해주세요. 두 값이 같을 경우 그 값을 return합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;
            int _evenSum = 0;   //  짝수 합
            int _oddSum = 0;    //  홀수 합
            for (int i = 0; i < num_list.Length; i++)
            {
                //  홀수면
                if (i % 2 == 1)
                    _oddSum += num_list[i];
                //  짝수면
                else
                    _evenSum += num_list[i];

                if (_evenSum > _oddSum)
                {
                    answer = _evenSum;
                }
                else
                {
                    answer = _oddSum;
                }
            }
            return answer;
        }
    }
    class 홀수_vs_짝수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numList01 = { 4, 2, 6, 1, 7, 6 };
            int[] _numList02 = { -1, 2, 5, 6, 3 };

            Console.WriteLine(_solution.solution(_numList01));
            Console.WriteLine(_solution.solution(_numList02));
        }
    }
    */
}
