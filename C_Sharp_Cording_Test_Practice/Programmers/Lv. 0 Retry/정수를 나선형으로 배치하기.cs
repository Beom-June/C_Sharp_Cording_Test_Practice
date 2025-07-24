using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 양의 정수 n이 매개변수로 주어집니다. 
 * n × n 배열에 1부터 n2 까지 정수를 
 * 인덱스 [0][0]부터 시계방향 나선형으로 배치한 이차원 배열을 
 * return 하는 solution 함수를 작성해 주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[,] solution(int n)
        {
            int[,] _answer = new int[n, n];
            int _num = 1; // 배열에 배치할 정수

            int _rowStart = 0, _rowEnd = n - 1;
            int _colStart = 0, _colEnd = n - 1;

            while (_num <= n * n)
            {
                // 위쪽 행 채우기
                for (int i = _colStart; i <= _colEnd; i++)
                {
                    _answer[_rowStart, i] = _num++;
                }
                _rowStart++;

                // 오른쪽 열 채우기
                for (int i = _rowStart; i <= _rowEnd; i++)
                {
                    _answer[i, _colEnd] = _num++;
                }
                _colEnd--;

                // 아래쪽 행 채우기
                if (_rowStart <= _rowEnd)
                {
                    for (int i = _colEnd; i >= _colStart; i--)
                    {
                        _answer[_rowEnd, i] = _num++;
                    }
                    _rowEnd--;
                }

                // 왼쪽 열 채우기
                if (_colStart <= _colEnd)
                {
                    for (int i = _rowEnd; i >= _rowStart; i--)
                    {
                        _answer[i, _colStart] = _num++;
                    }
                    _colStart++;
                }
            }

            return _answer;
        }
    }
    class 정수를_나선형으로_배치하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n1 = 4, _n2 = 5;

            int[,] result1 = _solution.solution(_n1);
            int[,] result2 = _solution.solution(_n2);

            PrintArray(result1);
            Console.WriteLine();
            PrintArray(result2);
        }

        static void PrintArray(int[,] arr)
        {
            int _rows = arr.GetLength(0);
            int _cols = arr.GetLength(1);

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    */
}
