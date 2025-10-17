using System;

/* Retry → 속도
 * 1 ~ n의 번호가 있는 택배 상자가 창고에 있습니다. 당신은 택배 상자들을 다음과 같이 정리했습니다.
 * 
 * 왼쪽에서 오른쪽으로 가면서 1번 상자부터 번호 순서대로 택배 상자를 한 개씩 놓습니다. 
 * 가로로 택배 상자를 w개 놓았다면 이번에는 오른쪽에서 왼쪽으로 가면서 그 위층에 택배 상자를 한 개씩 놓습니다. 
 * 그 층에 상자를 w개 놓아 가장 왼쪽으로 돌아왔다면 또다시 왼쪽에서 오른쪽으로 가면서 그 위층에 상자를 놓습니다. 
 * 이러한 방식으로 n개의 택배 상자를 모두 놓을 때까지 한 층에 w개씩 상자를 쌓습니다.
 * 
 * 위 그림은 w = 6일 때 택배 상자 22개를 쌓은 예시입니다.
 * 
 * 다음 날 손님은 자신의 택배를 찾으러 창고에 왔습니다. 
 * 당신은 손님이 자신의 택배 상자 번호를 말하면 해당 택배 상자를 꺼내줍니다. 
 * 택배 상자 A를 꺼내려면 먼저 A 위에 있는 다른 모든 상자를 꺼내야 A를 꺼낼 수 있습니다. 
 * 예를 들어, 위 그림에서 8번 상자를 꺼내려면 먼저 20번, 17번 상자를 꺼내야 합니다.
 * 
 * 당신은 꺼내려는 상자 번호가 주어졌을 때, 꺼내려는 상자를 포함해 총 몇 개의 택배 상자를 꺼내야 하는지 알고 싶습니다.
 * 
 * 창고에 있는 택배 상자의 개수를 나타내는 정수 n, 가로로 놓는 상자의 개수를 나타내는 정수 w와 꺼내려는 택배 상자의 번호를 나타내는 정수 num이 매개변수로 주어집니다. 
 * 이때, 꺼내야 하는 상자의 총개수를 return 하도록 solution 함수를 완성해 주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int n, int w, int num)
        {
            //int answer = 0;                 //  꺼내야 하는 상자의 총 개수
            //int _floor = (n + w - 1) / w;      //  꺼내려는 상자가 있는 층
            //int[,] _box = new int[_floor, w];    //  창고에 있는 택배 상자들
            //int _boxNum = 1;

            ////  배치
            //for (int i = 0; i < _floor; i++)
            //{
            //    if (i % 2 == 0) // 짝수층 → 왼쪽에서 오른쪽
            //    {
            //        for (int j = 0; j < w && _boxNum <= n; j++)
            //        {
            //            _box[i, j] = _boxNum++;
            //        }
            //    }
            //    else // 홀수층 → 오른쪽에서 왼쪽
            //    {
            //        for (int j = w - 1; j >= 0 && _boxNum <= n; j--)
            //        {
            //            _box[i, j] = _boxNum++;
            //        }
            //    }
            //}
            //answer = _floor - 1;
            //return answer;

            int _totalRows = (n + w - 1) / w;                   //  전체 층
            int _row = (num - 1) / w;                           //  꺼내려는 상자가 있는 층
            int _pos = (num - 1) % w;                           //  꺼내려는 상자가 몇 번째 칸에 있는지 계산
            int _col = (_row % 2 == 0) ? _pos : w - 1 - _pos;   // 층 방향이 지그재그이므로 실제 열(column) 계산,  짝수층: 왼쪽→오른쪽, 홀수층: 오른쪽→왼쪽

            int _answer = 1; // 자기 자신 포함

            for (int _r = _row + 1; _r < _totalRows; _r++)
            {
                // 마지막 층이면 남은 상자 수 계산
                int _maxBox = (_r == _totalRows - 1 && n % w != 0) ? (n % w) : w;

                // 해당 층에서의 첫 번째 열과 마지막 열
                int _colStart = (_r % 2 == 0) ? 0 : w - _maxBox;
                int _colEnd = (_r % 2 == 0) ? _maxBox - 1 : w - 1;

                if (_col >= _colStart && _col <= _colEnd)
                    _answer++;
            }
            return _answer;
        }
    }
    internal class 택배_상자_꺼내기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(22, 6, 8));            //  3
            Console.WriteLine(_solution.solution(13, 3, 6));            //  4
        }
    }
    */
}
