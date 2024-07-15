using System;

/* x 좌표와 y 좌표가 모두 양수이면 제1사분면에 속합니다.
 * x 좌표가 음수, y 좌표가 양수이면 제2사분면에 속합니다.
 * x 좌표와 y 좌표가 모두 음수이면 제3사분면에 속합니다.
 * x 좌표가 양수, y 좌표가 음수이면 제4사분면에 속합니다.
 * x 좌표 (x, y)를 차례대로 담은 정수 배열 dot이 매개변수로 주어집니다. 
 * 
 * 좌표 dot이 사분면 중 어디에 속하는지 1, 2, 3, 4 중 하나를 
 * return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] dot)
        {
            int x = dot[0];
            int y = dot[1];

            if (x > 0 && y > 0)
            {
                return 1; // 제1사분면
            }
            else if (x < 0 && y > 0)
            {
                return 2; // 제2사분면
            }
            else if (x < 0 && y < 0)
            {
                return 3; // 제3사분면
            }
            else if (x > 0 && y < 0)
            {
                return 4; // 제4사분면
            }
            else
            {
                return 0;
            }
        }
    }
    class 점의_위치_구하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _dot01 = { 2, 4 };
            int[] _dot02 = { -7, 9 };

            Console.WriteLine(_solution.solution(_dot01));
            Console.WriteLine(_solution.solution(_dot02));
        }
    }
    */
}