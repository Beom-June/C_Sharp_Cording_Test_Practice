using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 코딩테스트를 준비하는 머쓱이는 프로그래머스에서 문제를 풀고 나중에 다시 코드를 보면서 
 * 공부하려고 작성한 코드를 컴퓨터 바탕화면에 아무 위치에나 저장해 둡니다. 
 * 저장한 코드가 많아지면서 머쓱이는 본인의 컴퓨터 바탕화면이 너무 지저분하다고 생각했습니다. 
 * 프로그래머스에서 작성했던 코드는 그 문제에 가서 다시 볼 수 있기 때문에 저장해 둔 파일들을 
 * 전부 삭제하기로 했습니다.
 * 
 * 컴퓨터 바탕화면은 각 칸이 정사각형인 격자판입니다. 
 * 이때 컴퓨터 바탕화면의 상태를 나타낸 문자열 배열 wallpaper가 주어집니다. 
 * 파일들은 바탕화면의 격자칸에 위치하고 바탕화면의 격자점들은 바탕화면의 
 * 가장 왼쪽 위를 (0, 0)으로 시작해 (세로 좌표, 가로 좌표)로 표현합니다. 
 * 빈칸은 ".", 파일이 있는 칸은 "#"의 값을 가집니다. 드래그를 하면 파일들을 선택할 수 있고, 
 * 선택된 파일들을 삭제할 수 있습니다. 
 * 머쓱이는 최소한의 이동거리를 갖는 한 번의 드래그로 모든 파일을 선택해서 한 번에 지우려고 하며
 * 드래그로 파일들을 선택하는 방법은 다음과 같습니다.
 * 
 * 드래그는 바탕화면의 격자점 S(lux, luy)를 마우스 왼쪽 버튼으로 클릭한 상태로 
 * 격자점 E(rdx, rdy)로 이동한 뒤 마우스 왼쪽 버튼을 떼는 행동입니다. 
 * 이때, "점 S에서 점 E로 드래그한다"고 표현하고 점 S와 점 E를 각각 드래그의 시작점, 
 * 끝점이라고 표현합니다.
 * 
 * 점 S(lux, luy)에서 점 E(rdx, rdy)로 드래그를 할 때, 
 * "드래그 한 거리"는 |rdx - lux| + |rdy - luy|로 정의합니다.
 * 
 * 점 S에서 점 E로 드래그를 하면 바탕화면에서 두 격자점을 각각 왼쪽 위, 
 * 오른쪽 아래로 하는 직사각형 내부에 있는 모든 파일이 선택됩니다.
 * 
 * 예를 들어 wallpaper = [".#...", "..#..", "...#."]인 바탕화면을 그림으로 
 * 나타내면 다음과 같습니다.
 * 
 * eg1.png
 * 이러한 바탕화면에서 다음 그림과 같이 S(0, 1)에서 E(3, 4)로 드래그하면 세 개의 파일이 
 * 모두 선택되므로 드래그 한 거리 (3 - 0) + (4 - 1) = 6을 최솟값으로 모든 파일을 선택 가능합니다.
 * 
 * eg1-2.png
 * (0, 0)에서 (3, 5)로 드래그해도 모든 파일을 선택할 수 있지만 
 * 이때 드래그 한 거리는 (3 - 0) + (5 - 0) = 8이고 이전의 방법보다 거리가 늘어납니다.
 * 
 * 머쓱이의 컴퓨터 바탕화면의 상태를 나타내는 문자열 배열 
 * wallpaper가 매개변수로 주어질 때 바탕화면의 파일들을 
 * 한 번에 삭제하기 위해 최소한의 이동거리를 갖는 드래그의 시작점과 
 * 끝점을 담은 정수 배열을 return하는 solution 함수를 작성해 주세요. 
 * 드래그의 시작점이 (lux, luy), 끝점이 (rdx, rdy)라면 
 * 정수 배열 [lux, luy, rdx, rdy]를 return하면 됩니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(string[] wallpaper)
        {
            int[] answer = new int[4];

            //  각점
            int _lux = int.MaxValue;
            int _luy = int.MaxValue;
            int _rdx = int.MinValue;
            int _rdy = int.MinValue;

            for (int i = 0; i < wallpaper.Length; i++)
            {
                for (int j = 0; j < wallpaper[i].Length; j++) // <- 바깥 문자열 길이가 아니라 현재 줄 길이로 수정 필요
                {
                    // 1. 현재 위치 wallpaper[i][j]가 '#'인지 확인
                    if (wallpaper[i][j] == '#')
                    {
                        // 2. '#'이라면:
                        //    - _lux: Math.Min(_lux, i)  // 가장 왼쪽 위의 x좌표
                        //    - _luy: Math.Min(_luy, j)  // 가장 왼쪽 위의 y좌표
                        //    - _rdx: Math.Max(_rdx, i)  // 가장 오른쪽 아래의 x좌표
                        //    - _rdy: Math.Max(_rdy, j)  // 가장 오른쪽 아래의 y좌표
                        _lux = Math.Min(_lux, i);
                        _luy = Math.Min(_luy, j);
                        _rdx = Math.Max(_rdx, i);
                        _rdy = Math.Max(_rdy, j);
                    }
                }
            }

            // 끝점은 포함이므로 +1 필요
            return new int[] { _lux, _luy, _rdx + 1, _rdy + 1 };
        }
    }
    internal class 바탕화면_정리
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _wallpaper01 = { ".#...", "..#..", "...#." };
            string[] _wallpaper02 = { "..........", ".....#....", "......##..", "...##.....", "....#....." };
            string[] _wallpaper03 = { ".##...##.", "#..#.#..#", "#...#...#", ".#.....#.", "..#...#..", "...#.#...", "....#...." };
            string[] _wallpaper04 = { "..", "#." };

            Console.WriteLine(string.Join(", ", _solution.solution(_wallpaper01))); // [0, 1, 3, 4]
            Console.WriteLine(string.Join(", ", _solution.solution(_wallpaper02))); // [1, 3, 5, 8]
            Console.WriteLine(string.Join(", ", _solution.solution(_wallpaper03))); // [0, 0, 7, 9]
            Console.WriteLine(string.Join(", ", _solution.solution(_wallpaper04))); // [1, 0, 2, 1]

        }
    }
    */
}
