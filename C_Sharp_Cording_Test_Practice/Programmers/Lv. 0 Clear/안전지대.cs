using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 다음 그림과 같이 지뢰가 있는 지역과 지뢰에 인접한 
 * 위, 아래, 좌, 우 대각선 칸을 모두 위험지역으로 분류합니다.
 * 지뢰는 2차원 배열 board에 1로 표시되어 있고 board에는 지뢰가 매설 된 지역 1과, 
 * 지뢰가 없는 지역 0만 존재합니다.
 * 지뢰가 매설된 지역의 지도 board가 매개변수로 주어질 때, 
 * 안전한 지역의 칸 수를 return하도록 solution 함수를 완성해주세요.
 * 
 * 제한사항
 * board는 n * n 배열입니다.
 * 1 ≤ n ≤ 100
 * 지뢰는 1로 표시되어 있습니다.
 * board에는 지뢰가 있는 지역 1과 지뢰가 없는 지역 0만 존재합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[,] board)
        {
            int answer = 0;
            int _length = board.GetLength(0);

            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _length; j++)
                {
                    // 현재 칸이 지뢰 X
                    if (board[i, j] == 0)
                    {
                        // 주변 칸을 확인하면서 지뢰가 있는지 체크
                        bool _safe = true;
                        for (int x = i - 1; x <= i + 1; x++)
                        {
                            for (int y = j - 1; y <= j + 1; y++)
                            {
                                // 인덱스가 유효한 범위 내에 있고, 해당 칸이 지뢰인 경우
                                if (x >= 0 && x < _length && y >= 0 && y < _length && board[x, y] == 1)
                                {
                                    _safe = false;
                                    break;
                                }
                            }
                            if (!_safe)
                                break;
                        }

                        // 주변에 지뢰가 없는 경우, 안전한 칸 수를 증가
                        if (_safe)
                            answer++;
                    }
                }
            }

            return answer;
        }
    }
    class 안전지대
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _board1 = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int[,] _board2 = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0 } };
            int[,] _board3 = { { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } };

            Console.WriteLine(_solution.solution(_board1));
            Console.WriteLine(_solution.solution(_board2));
            Console.WriteLine(_solution.solution(_board3));
        }
    }
    */
}
