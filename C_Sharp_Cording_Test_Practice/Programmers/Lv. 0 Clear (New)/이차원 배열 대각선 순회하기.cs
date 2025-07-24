using System;

/* 2차원 정수 배열 board와 정수 k가 주어집니다.
 * 
 * i + j <= k를 만족하는 모든 (i, j)에 대한 board[i][j]의 합을 
 * return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[,] board, int k)
        {
            int answer = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i + j <= k)
                    {
                        answer += board[i, j];
                    }
                }
            }
            return answer;
        }
    }
    class 이차원_배열_대각선_순회하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _board = { { 0, 1, 2 }, { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };

            Console.WriteLine(_solution.solution(_board, 2));
        }
    }
    */
}