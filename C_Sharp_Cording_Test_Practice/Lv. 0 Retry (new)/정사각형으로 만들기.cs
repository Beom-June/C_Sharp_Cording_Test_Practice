using System;

/* Retry
 * 이차원 정수 배열 arr이 매개변수로 주어집니다. 
 * 
 * arr의 행의 수가 더 많다면 열의 수가 행의 수와 같아지도록 각 행의 끝에 0을 추가하고, 
 * 열의 수가 더 많다면 행의 수가 열의 수와 같아지도록 각 열의 끝에 0을 
 * 추가한 이차원 배열을 return 하는 solution 함수를 작성해 주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[,] solution(int[,] arr)
        {
            int _row = arr.GetLength(0);
            int _col = arr.GetLength(1);

            int _size = Math.Max(_row, _col);

            // 새로운 정사각형 배열 생성 (size x size)
            int[,] answer = new int[_size, _size];

            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    answer[i, j] = arr[i, j];
                }
            }
            return answer;
        }
    }
    class 정사각형으로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _arr01 = { { 572, 22, 37 }, { 287, 726, 384 }, { 85, 137, 292 }, { 487, 13, 876 } };
            int[,] _arr02 = { { 57, 192, 534, 2 }, { 9, 345, 192, 999 } };
            int[,] _arr03 = { { 1, 2 }, { 3, 4 } };

            PrintArray(_solution.solution(_arr01));
            PrintArray(_solution.solution(_arr02));
            PrintArray(_solution.solution(_arr03));
        }
        static void PrintArray(int[,] arr)
        {
            int _row = arr.GetLength(0);
            int _col = arr.GetLength(1);

            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    */
}