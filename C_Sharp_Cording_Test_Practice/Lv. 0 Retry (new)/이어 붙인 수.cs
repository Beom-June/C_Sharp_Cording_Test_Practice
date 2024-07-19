using System;

/* Retry
 * 정수가 담긴 리스트 num_list가 주어집니다. 
 * num_list의 홀수만 순서대로 이어 붙인 수와 
 * 짝수만 순서대로 이어 붙인 수의 합을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] num_list)
        {
            int answer = 0;
            string _odd = "";
            string _even = "";
            for (int i = 0; i < num_list.Length; i++)
            {
                //  홀수면
                if(num_list[i] % 2 == 1)
                {
                    _odd += num_list[i].ToString();
                }
                //  짝수면
                else
                {
                    _even += num_list[i].ToString();
                }
            }
            int _oddSum = string.IsNullOrEmpty(_odd) ? 0 : int.Parse(_odd);
            int _evenSum = string.IsNullOrEmpty(_even) ? 0 : int.Parse(_even);
            answer = _oddSum + _evenSum;
            return answer;
        }
    }
    class 이어_붙인_수
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
