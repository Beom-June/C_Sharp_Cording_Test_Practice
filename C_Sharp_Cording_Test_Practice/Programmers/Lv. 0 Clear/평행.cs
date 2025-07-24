using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 점 네 개의 좌표를 담은 이차원 배열  dots가 다음과 같이 매개변수로 주어집니다.
 * [[x1, y1], [x2, y2], [x3, y3], [x4, y4]]
 * 주어진 네 개의 점을 두 개씩 이었을 때, 두 직선이 평행이 되는 경우가 있으면 1을 
 * 없으면 0을 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[,] dots)
        {
            // 첫 번째 조건: (x1, y1)과 (x2, y2)를 지나는 직선의 기울기와
            //            (x3, y3)과 (x4, y4)를 지나는 직선의 기울기가 같은지 비교
            if ((double)(dots[0, 0] - dots[1, 0]) / (dots[0, 1] - dots[1, 1]) == (double)(dots[2, 0] - dots[3, 0]) / (dots[2, 1] - dots[3, 1]))
            {
                return 1;
            }
            // 두 번째 조건: (x1, y1)과 (x3, y3)를 지나는 직선의 기울기와
            //            (x2, y2)과 (x4, y4)를 지나는 직선의 기울기가 같은지 비교
            if ((double)(dots[0, 0] - dots[2, 0]) / (dots[0, 1] - dots[2, 1]) == (double)(dots[1, 0] - dots[3, 0]) / (dots[1, 1] - dots[3, 1]))
            {
                return 1;
            }
            // 세 번째 조건: (x1, y1)과 (x4, y4)를 지나는 직선의 기울기와
            //            (x2, y2)과 (x3, y3)를 지나는 직선의 기울기가 같은지 비교
            if ((double)(dots[0, 0] - dots[3, 0]) / (dots[0, 1] - dots[3, 1]) == (double)(dots[1, 0] - dots[2, 0]) / (dots[1, 1] - dots[2, 1]))
            {
                return 1;
            }

            return 0;
        }
    }
    class 평행
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _dots1 = { { 1, 4 }, { 9, 2 }, { 3, 8 }, { 11, 6 } };
            int[,] _dots2 = { { 3, 5 }, { 4, 1 }, { 2, 4 }, { 5, 10 } };

            Console.WriteLine(_solution.solution(_dots1));
            Console.WriteLine(_solution.solution(_dots2));
        }
    }
    */
}
