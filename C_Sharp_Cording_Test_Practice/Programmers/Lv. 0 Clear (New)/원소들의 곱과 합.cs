using System;

/* 정수가 담긴 리스트 num_list가 주어질 때, 
 * 모든 원소들의 곱이 모든 원소들의 합의 제곱보다 작으면 1을 크면 0을 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;
            int _gop = 1;
            int _total = 0;
            int _plusZeGop = 1;
            for (int i = 0; i < num_list.Length; i++)
            {
                _gop *= num_list[i];
            }
            for (int i = 0; i < num_list.Length; i++)
            {
                _total += num_list[i];
            }
            _plusZeGop = _total * _total;

            if (_gop < _plusZeGop)
                answer = 1;
            else
                answer = 0;
            return answer;
        }
    }
    class 원소들의_곱과_합
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numList01 = { 3, 4, 5, 2, 1 };
            int[] _numList02 = { 5, 7, 8, 3 };

            Console.WriteLine(_solution.solution(_numList01));
            Console.WriteLine(_solution.solution(_numList02));
        }
    }
    */
}
