using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 지나다니는 길을 'O', 장애물을 'X'로 나타낸 직사각형 격자 모양의 공원에서 로봇 강아지가 산책을 하려합니다. 
 * 산책은 로봇 강아지에 미리 입력된 명령에 따라 진행하며, 명령은 다음과 같은 형식으로 주어집니다.
 * ["방향 거리", "방향 거리" … ]
 * 예를 들어 "E 5"는 로봇 강아지가 현재 위치에서 동쪽으로 5칸 이동했다는 의미입니다. 로봇 강아지는 명령을 수행하기 전에 다음 두 가지를 먼저 확인합니다.
 * 
 * 주어진 방향으로 이동할 때 공원을 벗어나는지 확인합니다.
 * 주어진 방향으로 이동 중 장애물을 만나는지 확인합니다.
 * 위 두 가지중 어느 하나라도 해당된다면, 로봇 강아지는 해당 명령을 무시하고 다음 명령을 수행합니다.
 * 공원의 가로 길이가 W, 세로 길이가 H라고 할 때, 공원의 좌측 상단의 좌표는 (0, 0), 우측 하단의 좌표는 (H - 1, W - 1) 입니다.
 * 
 * 공원을 나타내는 문자열 배열 park, 로봇 강아지가 수행할 명령이 담긴 문자열 배열 routes가 매개변수로 주어질 때, 
 * 로봇 강아지가 모든 명령을 수행 후 놓인 위치를 [세로 방향 좌표, 가로 방향 좌표] 순으로 배열에 담아 return 하도록 solution 함수를 완성해주세요.
 * 
 * 제한사항
 * 3 ≤ park의 길이 ≤ 50
 * 3 ≤ park[i]의 길이 ≤ 50
 * park[i]는 다음 문자들로 이루어져 있으며 시작지점은 하나만 주어집니다.
 * S : 시작 지점
 * O : 이동 가능한 통로
 * X : 장애물
 * 
 * park는 직사각형 모양입니다.
 * 1 ≤ routes의 길이 ≤ 50
 * 
 * routes의 각 원소는 로봇 강아지가 수행할 명령어를 나타냅니다.
 * 로봇 강아지는 routes의 첫 번째 원소부터 순서대로 명령을 수행합니다.
 * routes의 원소는 "op n"과 같은 구조로 이루어져 있으며, op는 이동할 방향, n은 이동할 칸의 수를 의미합니다.
 * 
 * op는 다음 네 가지중 하나로 이루어져 있습니다.
 * N : 북쪽으로 주어진 칸만큼 이동합니다.
 * S : 남쪽으로 주어진 칸만큼 이동합니다.
 * W : 서쪽으로 주어진 칸만큼 이동합니다.
 * E : 동쪽으로 주어진 칸만큼 이동합니다.
 * 1 ≤ n ≤ 9
 */
namespace C_Sharp_Cording_Test_Practice.Programmers
{
    /*
    public class Solution
    {
        public int[] solution(string[] park, string[] routes)
        {
            // 공원 격자 초기화
            char[][] _parkGrid = park.Select(row => row.ToCharArray()).ToArray();
            int _rows = _parkGrid.Length;
            int _cols = _parkGrid[0].Length;

            // 시작 위치 찾기
            int _startX = 0, _startY = 0;
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (_parkGrid[i][j] == 'S')
                    {
                        _startX = i;
                        _startY = j;
                        break;
                    }
                }
            }

            // 방향 벡터 설정
            Dictionary<char, (int dx, int dy)> _directions = new Dictionary<char, (int dx, int dy)>()
            {
                { 'N', (-1, 0) },
                { 'S', (1, 0) },
                { 'W', (0, -1) },
                { 'E', (0, 1) }
            };

            // 명령어 처리
            foreach (string route in routes)
            {
                string[] split = route.Split(' ');
                char _dir = split[0][0];
                int _distance = int.Parse(split[1]);

                int _tempX = _startX;
                int _tempY = _startY;

                bool _isBlocked = false;

                for (int step = 1; step <= _distance; step++)
                {
                    int _nextX = _startX + _directions[_dir].dx * step;
                    int _nextY = _startY + _directions[_dir].dy * step;

                    // 범위 초과 체크
                    if (_nextX < 0 || _nextX >= _rows || _nextY < 0 || _nextY >= _cols)
                    {
                        _isBlocked = true;
                        break;
                    }

                    // 장애물 체크
                    if (_parkGrid[_nextX][_nextY] == 'X')
                    {
                        _isBlocked = true;
                        break;
                    }
                }

                // 이동 가능할 때만 실제 이동
                if (!_isBlocked)
                {
                    _startX += _directions[_dir].dx * _distance;
                    _startY += _directions[_dir].dy * _distance;
                }
            }

            return new int[] { _startX, _startY };
        }
    }
    internal class 공원_산책
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _park01 = { "SOO", "OOO", "OOO" };
            string[] _park02 = { "SOO", "OXX", "OOO" };
            string[] _park03 = { "OSO", "OOO", "OXO", "OOO" };

            string[] _routes01 = { "E 2", "S 2", "W 1" };
            string[] _routes02 = { "E 2", "S 2", "W 1" };
            string[] _routes03 = { "E 2", "S 3", "W 1" };

            Console.WriteLine(string.Join(", ", _solution.solution(_park01, _routes01))); // 2, 1
            Console.WriteLine(string.Join(", ", _solution.solution(_park02, _routes02))); // 0, 1
            Console.WriteLine(string.Join(", ", _solution.solution(_park03, _routes03))); // 0, 0
        }
    }
    */
}