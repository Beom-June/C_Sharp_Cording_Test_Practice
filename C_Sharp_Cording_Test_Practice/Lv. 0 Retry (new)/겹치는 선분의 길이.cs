using System;

/* Retry
 * 선분 3개가 평행하게 놓여 있습니다. 세 선분의 시작과 끝 좌표가 
 * [[start, end], [start, end], [start, end]] 형태로 들어있는 2차원 배열 lines가 매개변수로 주어질 때, 
 * 두 개 이상의 선분이 겹치는 부분의 길이를 return 하도록 solution 함수를 완성해보세요.
 * 
 * lines가 [[0, 2], [-3, -1], [-2, 1]]일 때 그림으로 나타내면 다음과 같습니다.
 * 
 * 선분이 두 개 이상 겹친 곳은 [-2, -1], [0, 1]로 길이 2만큼 겹쳐있습니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[,] lines)
        {
            int answer = 0;
            int _max = 0;
            int _min = 0;
            int[] _lineArr = new int[200];      //  선분의 범위 표현 (-100 ~ 100)

            for (int i = 0; i < 3; i++)
            {
                _max = Math.Max(lines[i, 0], lines[i, 1]);
                _min = Math.Min(lines[i, 0], lines[i, 1]);

                //  선분의 범위에 해당
                for (int j = _min; j < _max; j++)
                {
                    //  +100은 음수 인덱스 처리 위함
                    _lineArr[j + 100]++;
                }
            }

            for (int i = 0; i < _lineArr.Length; i++)
            {
                if (_lineArr[i] > 1)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
    class 겹치는_선분의_길이
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _lines01 = { { 0, 1 }, { 2, 5 }, { 3, 9 } };
            int[,] _lines02 = { { -1, 1 }, { 1, 3 }, { 3, 9 } };
            int[,] _lines03 = { { 0, 5 }, { 3, 9 }, { 1, 10 } };

            Console.WriteLine(_solution.solution(_lines01));        //  2
            Console.WriteLine(_solution.solution(_lines02));        //  0
            Console.WriteLine(_solution.solution(_lines03));        //  8
        }
    }
    */
}