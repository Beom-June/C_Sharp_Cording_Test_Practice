using System;

/* Retry
 * 정수 배열 num_list와 정수 n이 매개변수로 주어집니다. 
 * num_list를 다음 설명과 같이 2차원 배열로 바꿔 return하도록 solution 함수를 완성해주세요.
 * 
 * num_list가 [1, 2, 3, 4, 5, 6, 7, 8] 로 길이가 8이고 n이 2이므로 
 * num_list를 2 * 4 배열로 다음과 같이 변경합니다. 
 * 
 * 2차원으로 바꿀 때에는 num_list의 원소들을 앞에서부터 n개씩 나눠 2차원 배열로 변경합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[,] solution(int[] num_list, int n)
        {
            int _rows = num_list.Length / n;
            int[,] answer = new int[_rows, n];
            //  값 설정: 이중 for 루프를 사용하지 않고,
            //  단일 for 루프에서 i를 사용해 2차원 배열의 행과 열을 계산
            for (int i = 0; i < num_list.Length; i++)
            {
                answer[i / n, i % n] = num_list[i];
            }
            return answer;
        }
    }
    class _2차원으로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numList = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[,] result = _solution.solution(_numList, 2);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    */
}
