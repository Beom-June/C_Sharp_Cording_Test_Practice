using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 선분 3개가 평행하게 놓여 있습니다. 
 * 세 선분의 시작과 끝 좌표가 [[start, end], [start, end], [start, end]] 형태로 들어있는 
 * 2차원 배열 lines가 매개변수로 주어질 때, 두 개 이상의 선분이 겹치는 부분의 길이를 return 
 * 하도록 solution 함수를 완성해보세요.
 * lines가 [[0, 2], [-3, -1], [-2, 1]]일 때 그림으로 나타내면 다음과 같습니다.
 * 선분이 두 개 이상 겹친 곳은 [-2, -1], [0, 1]로 길이 2만큼 겹쳐있습니다.
 * 
 * 제한 사항
 * lines의 길이 = 3
 * lines의 원소의 길이 = 2
 * 모든 선분은 길이가 1 이상입니다.
 * lines의 원소는 [a, b] 형태이며, a, b는 각각 선분의 양 끝점 입니다.
 * -100 ≤ a < b ≤ 100
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class 겹치는_선분의_길이
    {
        public class Solution
        {
            public int solution(int[,] lines)
            {
                int answer = 0;
                int[] _array = new int[200];

                for (int i = 0; i < 3; i++)
                {
                    // 두 선분이 겹치는 경우의 시작점과 끝점을 찾아 겹치는 길이를 계산
                    int overlapStart = Math.Max(lines[i, 0], lines[i, 1]);
                    int overlapEnd = Math.Min(lines[i, 0], lines[i, 1]);
                    for (int j = overlapEnd; j < overlapStart; j++)
                    {

                        _array[j + 100]++;
                    }
                }
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i] > 1)
                    {
                        answer++;
                    }
                }

                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _lines1 = { { 0, 1 }, { 2, 5 }, { 3, 9 } };
            int[,] _lines2 = { { -1, 1 }, { 1, 3 }, { 3, 9 } };
            int[,] _lines3 = { { 0, 5 }, { 3, 9 }, { 1, 10 } };

            Console.WriteLine(_solution.solution(_lines1));     //  2
            Console.WriteLine(_solution.solution(_lines2));     //  0
            Console.WriteLine(_solution.solution(_lines3));     //  8
        }
    }
    */
}
