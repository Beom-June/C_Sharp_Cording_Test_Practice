using System;

/* Retry
 * 머쓱이는 RPG게임을 하고 있습니다. 
 * 게임에는 up, down, left, right 방향키가 있으며 각 키를 누르면 
 * 위, 아래, 왼쪽, 오른쪽으로 한 칸씩 이동합니다. 
 * 
 * 예를 들어 [0,0]에서 up을 누른다면 캐릭터의 좌표는 [0, 1], 
 * down을 누른다면 [0, -1], left를 누른다면 [-1, 0], right를 누른다면 [1, 0]입니다. 
 * 머쓱이가 입력한 방향키의 배열 keyinput와 맵의 크기 board이 매개변수로 주어집니다. 
 * 캐릭터는 항상 [0,0]에서 시작할 때 키 입력이 모두 끝난 뒤에 캐릭터의 좌표 [x, y]를 
 * return하도록 solution 함수를 완성해주세요.
 * 
 * [0, 0]은 board의 정 중앙에 위치합니다. 
 * 예를 들어 board의 가로 크기가 9라면 캐릭터는 왼쪽으로 최대 [-4, 0]까지 
 * 오른쪽으로 최대 [4, 0]까지 이동할 수 있습니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(string[] keyinput, int[] board)
        {
            int _x = 0;
            int _y = 0;

            // board의 최대 x, y 범위를 계산
            int _maxX = (board[0] - 1) / 2;
            int _maxY = (board[1] - 1) / 2;

            //  좌, 우는 x 좌표
            //  위, 아래는 y 좌표
            for (int i = 0; i < keyinput.Length; i++)
            {
                switch (keyinput[i])
                {
                    case "up":
                        if (_y < _maxY) _y++;
                        break;
                    case "down":
                        if (_y > -_maxY) _y--;
                        break;
                    case "left":
                        if (_x > -_maxX) _x--;
                        break;
                    case "right":
                        if (_x < _maxX) _x++;
                        break;
                    default:
                        break;
                }
            }
            int[] answer = new int[] { _x, _y };
            return answer;
        }
    }
    class 캐릭터의_좌표
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _ketinput01 = { "left", "right", "up", "right", "right" };
            string[] _ketinput02 = { "down", "down", "down", "down", "down" };

            int[] _board01 = { 11, 11 };
            int[] _board02 = { 7, 9 };

            foreach (var i in _solution.solution(_ketinput01, _board01))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (var i in _solution.solution(_ketinput02, _board02))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
