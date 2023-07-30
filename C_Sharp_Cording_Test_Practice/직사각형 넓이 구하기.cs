using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2차원 좌표 평면에 변이 축과 평행한 직사각형이 있습니다. 
 * 직사각형 네 꼭짓점의 좌표 [[x1, y1], [x2, y2], [x3, y3], [x4, y4]]가 담겨있는 
 * 배열 dots가 매개변수로 주어질 때, 직사각형의 넓이를 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[,] dots)
        {
            int answer = 0;
            //// 네 점의 좌표
            //int _x1 = dots[0, 0];
            //int _y1 = dots[0, 1];

            //int _x2 = dots[1, 0];
            //int _y2 = dots[1, 1];

            //int _x3 = dots[2, 0];
            //int _y3 = dots[2, 1];

            //int _x4 = dots[3, 0];
            //int _y4 = dots[3, 1];

            //// 직사각형의 가로와 세로 길이
            //int _width = Math.Abs(_x2 - _x1);
            //int _height = Math.Abs(_y3 - _y2);

            //// 직사각형의 넓이를 계산
            //answer = _width * _height;

            int[] _x = new int[4];
            int[] _y = new int[4];

            for (int i = 0; i < 4; i++)
            {
                _x[i] = dots[i, 0];
                _y[i] = dots[i, 1];
            }
            answer = (_x.Max() - _x.Min()) * (_y.Max() - _y.Min());

            return answer;
        }
    }
    class 직사각형_넓이_구하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _dots1 = { { 1, 1 }, { 2, 1 }, { 2, 2 }, { 1, 2 } };
            int[,] _dots2 = { { -1, -1 }, { 1, 1 }, { 1, -1 }, { -1, 1 } };

            Console.WriteLine(_solution.solution(_dots1));
            Console.WriteLine(_solution.solution(_dots2));
        }
    }
*/
}
