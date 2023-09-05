using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 이차원 정수 배열 arr이 매개변수로 주어집니다. 
 * arr의 행의 수가 더 많다면 열의 수가 행의 수와 같아지도록 각 행의 끝에 0을 추가하고, 
 * 열의 수가 더 많다면 행의 수가 열의 수와 같아지도록 각 열의 끝에 0을 추가한 
 * 이차원 배열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[,] solution(int[,] arr)
        {
            int _rows = arr.GetLength(0);
            int _cols = arr.GetLength(1);

            // 행의 수가 더 많으면 열의 수를 행의 수와 동일하게 만들기 위해 0을 추가
            if (_rows > _cols)
            {
                int[,] _adjustedArr = new int[_rows, _rows];

                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _cols; j++)
                    {
                        _adjustedArr[i, j] = arr[i, j];
                    }
                }

                return _adjustedArr;
            }

            // 열의 수가 더 많으면 행의 수를 열의 수와 동일하게 만들기 위해 0을 추가
            else if (_cols > _rows)
            {
                int[,] _adjustedArr = new int[_cols, _cols];

                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 0; j < _cols; j++)
                    {
                        _adjustedArr[i, j] = arr[i, j];
                    }
                }

                return _adjustedArr;
            }
            // 이미 정사각형 모양인 경우, 그대로 반환
            else
            {
                return arr;
            }
        }
    }
    class 정사각형으로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _arr1 = { { 572, 22, 37 }, { 287, 726, 384 }, { 85, 137, 292 }, { 487, 13, 876 } };
            int[,] _arr2 = { { 57, 192, 534, 2 }, { 9, 345, 192, 999 } };
            int[,] _arr3 = { { 1, 2 }, { 3, 4 } };

            foreach (var _result in _solution.solution(_arr1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_arr2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_arr3))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
