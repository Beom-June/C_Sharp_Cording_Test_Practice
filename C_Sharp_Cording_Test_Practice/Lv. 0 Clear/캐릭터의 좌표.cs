using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 머쓱이는 RPG게임을 하고 있습니다. 
 * 게임에는 up, down, left, right 방향키가 있으며 
 * 각 키를 누르면 위, 아래, 왼쪽, 오른쪽으로 한 칸씩 이동합니다. 
 * 예를 들어 [0,0]에서 up을 누른다면 캐릭터의 좌표는 [0, 1], down을 누른다면 
 * [0, -1], left를 누른다면 [-1, 0], right를 누른다면 [1, 0]입니다. 
 * 머쓱이가 입력한 방향키의 배열 keyinput와 맵의 크기 board이 매개변수로 주어집니다. 
 * 캐릭터는 항상 [0,0]에서 시작할 때 키 입력이 모두 끝난 뒤에 
 * 캐릭터의 좌표 [x, y]를 return하도록 solution 함수를 완성해주세요.
 *
 * [0, 0]은 board의 정 중앙에 위치합니다. 
 * 예를 들어 board의 가로 크기가 9라면 
 * 캐릭터는 왼쪽으로 최대 [-4, 0]까지 오른쪽으로 최대 [4, 0]까지 이동할 수 있습니다.
*/

/* right, left -> x축
 * up, down -> y 축
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        // keyinput -> 키입력 배열, board -> 보드판 크기 배열
        public int[] solution(string[] keyinput, int[] board)
        {
            int[] answer = new int[2];
            answer[0] = 0; // x 좌표 초기화
            answer[1] = 0; // y 좌표 초기화

            for (int i = 0; i < keyinput.Length; i++)
            {
                if (keyinput[i] == "up")
                {
                    if (board[1] / 2 == answer[1])
                    {
                        continue;
                    }
                    else
                    {
                        answer[1]++;
                    }
                }
                else if (keyinput[i] == "down")
                {
                    if (board[1] / 2 * -1 == answer[1])
                    {
                        continue;
                    }
                    else
                    {
                        answer[1]--;
                    }
                }
                else if (keyinput[i] == "left")
                {
                    if (board[0] / 2 * -1 == answer[0])
                    {
                        continue;
                    }
                    else
                    {
                        answer[0]--;
                    }
                }
                else if (keyinput[i] == "right")
                {
                    if (board[0] / 2 == answer[0])
                    {
                        continue;
                    }
                    else
                    {
                        answer[0]++;
                    }
                }
            }
            return answer;
        }
    }
    class 캐릭터의_좌표
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _keyInput1 = { "left", "right", "up", "right", "right" };
            string[] _keyInput2 = { "down", "down", "down", "down", "down" };

            int[] _board1 = { 11, 11 };
            int[] _board2 = { 7, 9 };

            Console.WriteLine(_solution.solution(_keyInput1, _board1));
            Console.WriteLine(_solution.solution(_keyInput2, _board2));
        }
    }
    */
}
