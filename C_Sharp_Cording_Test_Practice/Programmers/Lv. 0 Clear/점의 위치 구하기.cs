using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 사분면은 한 평면을 x축과 y축을 기준으로 나눈 네 부분입니다. 
 * 사분면은 아래와 같이 1부터 4까지 번호를매깁니다.
 * x 좌표와 y 좌표가 모두 양수이면 제1사분면에 속합니다.
 * x 좌표가 음수, y 좌표가 양수이면 제2사분면에 속합니다.
 * x 좌표와 y 좌표가 모두 음수이면 제3사분면에 속합니다.
 * x 좌표가 양수, y 좌표가 음수이면 제4사분면에 속합니다.
 * x 좌표 (x, y)를 차례대로 담은 정수 배열 dot이 매개변수로 주어집니다. 
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
            int answer = 0;
            if (dot[0] < 0)
            {
                if (dot[1] < 0)
                {
                    answer = 3;
                }
                else
                {
                    answer = 2;
                }
            }
            else
            {
                if (dot[1] > 0)
                {
                    answer = 1;
                }
                else
                {
                    answer = 4;
                }
            }
            return answer;
        }
    }
    class 점의_위치_구하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();
            int[] _dot = { 2, 4 };
            int _result = _solution.solution(_dot);

            Console.WriteLine(_result);
        }
    }
    */
}
