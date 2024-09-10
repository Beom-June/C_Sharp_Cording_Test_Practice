using System;
using System.Linq;

/* 2차원 좌표 평면에 변이 축과 평행한 직사각형이 있습니다. 
 * 직사각형 네 꼭짓점의 좌표 [[x1, y1], [x2, y2], [x3, y3], [x4, y4]]가 
 * 담겨있는 배열 dots가 매개변수로 주어질 때, 직사각형의 넓이를 
 * return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[,] dots)
        {
            int answer = 0;
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

            int[,] _dots01 = { { 1, 1 }, { 2, 1 }, { 2, 2 }, { 1, 2 } };
            int[,] _dots02 = { { -1, -1 }, { 1, 1 }, { 1, -1 }, { -1, 1 } };

            Console.WriteLine(_solution.solution(_dots01));
            Console.WriteLine(_solution.solution(_dots02));
        }
    }
    */
}