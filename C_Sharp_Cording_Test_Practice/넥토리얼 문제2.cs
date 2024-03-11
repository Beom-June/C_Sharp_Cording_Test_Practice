using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/* 연동이는 미니 카트라이더를 플레이중이다.
 * 미니 카트라이더에서 카트 조작은 좌우 방향만 조작하며 카트는 앞으로 자동으로 전진
 * 현재 플레이 중인 게임 트랙에서는 3개의 차선이 존재하며 카트는 하나의 차선으로만 달릴 수 있음
 * 트랙에는 장애물들이 존재, 카트는 좌우 이동을 통해 장애물을 피하는 것은 가능하지만 장애물이 있는
 * 위치로 이동은 불가능 하다
 * 
 * 예를 들어 카트가 1차선에 있고 2차선에 장애물이 있는 경우 3차선으로 이동하는 것은 가능하지만
 * 2차선으로 이동하는 것은 불가능 하다. 시작시 카트는 가운데 차선인 2차선에 시작하며 최소의 좌우
 * 이동 조작으로 골인에 도달 해야 한다. 1차선에서 2차선으로 또는 1차선에서 3차선으로 이동하는 것은
 * 각각 1번의 이동으로 간주
 * 
 * < 예제 >
 * n = 3, obstacleLanes = {2, 1, 2}
 * 연동이는 아래 예제에서 첫 조작으로 3차선으로 이동. 이후 추가 조작 없이 골에 도달
 * 최소 요구되는 조작은 1회
 * 
 * <함수 설명>
 * 함수 minimumMovement를 작성하시오
 * 
 * minimumMovement는 다음의 파라미터를 가진다:
 * int obstacleLnaes[n] : 각 칸 별 장애물의 차선위치
 * 
 * 반환값
 * int : 연동이가 골인에 도착 할 수 있는 최소 좌우 이동 횟수
 * 
 * 제약 조건
 * 1 <= n <= 10^5
 * 1 <= obstacleLanes[i] <= 3 (0 <= i < n)
 * 모든 레이스는 골인에 도착이 보장
 * 
 * <예제 1>
 * 입력 값 : {2, 1, 2}
 * 출력 값 : 1
 * 
 * <예제 2>
 * 입력 값 : {2, 1, 3, 2}
 * 출력 값 : 2
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class 넥토리얼_문제2
    {
        public static int minimumMovement(List<int> obstacleLanes)
        {
            int _n = obstacleLanes.Count;           //  레인의 갯수
            int _count = 0;                         //  연동이가 최소 좌우 이동 횟수
            int _prev = obstacleLanes[0];           //  첫 장애물 무조건 회피

            // 최소 조작은 1부터라 i = 1 부터 시작
            for (int i = 1; i < _n; i++)
            {
                int _curr = obstacleLanes[i];       // 현재 장애물 위치

                if (_curr == _prev)
                {
                    _count++;

                }
                else
                {
                    _prev = _curr;
                }
            }
            return _count;
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int obstacleLanesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> obstacleLanes = new List<int>();

            for (int i = 0; i < obstacleLanesCount; i++)
            {
                int obstacleLanesItem = Convert.ToInt32(Console.ReadLine().Trim());
                obstacleLanes.Add(obstacleLanesItem);
            }

            int result = 넥토리얼_문제2.minimumMovement(obstacleLanes);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
    */
}
