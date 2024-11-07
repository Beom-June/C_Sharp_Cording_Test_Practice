using System;
/* Retry
 * 다음 그림과 같이 지뢰가 있는 지역과 지뢰에 인접한 위, 아래, 좌, 우 대각선 칸을 모두 위험지역으로 분류합니다.
 * 
 * 지뢰는 2차원 배열 board에 1로 표시되어 있고 board에는 지뢰가 매설 된 지역 1과, 지뢰가 없는 지역 0만 존재합니다.
 * 지뢰가 매설된 지역의 지도 board가 매개변수로 주어질 때, 안전한 지역의 칸 수를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[,] board)
        {
            int _rows = board.GetLength(0);
            int _cols = board.GetLength(1);
            int[,] _dangerMap = (int[,])board.Clone();

            // 방향 배열 설정 (위, 아래, 좌, 우, 대각선 4방향)
            //            (-1, -1) | (-1, 0) | (-1, +1)
            //              ----------------------------
            //             (0, -1) |    *    |  (0, +1)
            //              ----------------------------
            //              (+1, -1) | (+1, 0) | (+1, +1)
            int[] _dx = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] _dy = { -1, 0, 1, 1, 1, 0, -1, -1 };

            // 지뢰 주변을 위험 지역으로 표시
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (board[i, j] == 1) // 지뢰 발견
                    {
                        // 8방향 탐색
                        for (int d = 0; d < 8; d++)
                        {
                            int _nx = i + _dx[d];
                            int _ny = j + _dy[d];

                            // 위험 지역으로 설정, 범위 안에서만 표시
                            if (_nx >= 0 && _nx < _rows && _ny >= 0 && _ny < _cols && _dangerMap[_nx, _ny] == 0)
                            {
                                _dangerMap[_nx, _ny] = -1; // 위험 지역으로 표시
                            }
                        }
                    }
                }
            }

            // 안전 지역 카운트
            int _safeCount = 0;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (_dangerMap[i, j] == 0)
                    {
                        _safeCount++;
                    }
                }
            }
            return _safeCount;
        }
    }
    class 안전지대
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _board01 = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int[,] _board02 = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0 } };
            int[,] _board03 = { { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } };

            Console.WriteLine(_solution.solution(_board01));    //  16
            Console.WriteLine(_solution.solution(_board02));    //  13
            Console.WriteLine(_solution.solution(_board03));    //  0
        }
    }
    */
}