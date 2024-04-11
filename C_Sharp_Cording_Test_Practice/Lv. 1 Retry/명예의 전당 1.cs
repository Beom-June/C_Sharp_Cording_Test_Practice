using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * "명예의 전당"이라는 TV 프로그램에서는 매일 1명의 가수가 노래를 부르고, 
 * 시청자들의 문자 투표수로 가수에게 점수를 부여합니다. 매일 출연한 가수의 점수가 
 * 지금까지 출연 가수들의 점수 중 상위 k번째 이내이면 해당 가수의 점수를 명예의 전당이라는 
 * 목록에 올려 기념합니다. 
 * 
 * 즉 프로그램 시작 이후 초기에 k일까지는 모든 출연 가수의 점수가 명예의 전당에 오르게 됩니다. 
 * k일 다음부터는 출연 가수의 점수가 기존의 명예의 전당 목록의 k번째 순위의 가수 점수보다 더 높으면, 
 * 출연 가수의 점수가 명예의 전당에 오르게 되고 기존의 k번째 순위의 점수는 명예의 전당에서 내려오게 됩니다.
 * 
 * 이 프로그램에서는 매일 "명예의 전당"의 최하위 점수를 발표합니다. 
 * 예를 들어, k = 3이고, 7일 동안 진행된 가수의 점수가 [10, 100, 20, 150, 1, 100, 200]이라면, 
 * 명예의 전당에서 발표된 점수는 아래의 그림과 같이 [10, 10, 10, 20, 20, 100, 100]입니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int k, int[] score)
        {
            int[] answer = new int[score.Length];
            List<int> _board = new List<int>();

            for (int i = 0; i < score.Length; i++)
            {
                if(_board.Count == k)
                {
                    if(_board[0] > score[i])
                    {
                        answer[i] = _board[0];
                        continue;
                    }
                    _board.RemoveAt(0);
                }
                _board.Add(score[i]);
                _board.Sort();
                answer[i] = _board[0];
            }
            return answer;
        }
    }
    class 명예의_전당_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _score01 = { 10, 100, 20, 150, 1, 100, 200 };
            int[] _score02 = { 0, 300, 40, 300, 20, 70, 150, 50, 500, 1000 };

            Console.WriteLine(String.Join(", ", _solution.solution(3, _score01)));      //  10, 10, 10, 20, 20, 100, 100
            Console.WriteLine(String.Join(", ", _solution.solution(4, _score02)));      //  0, 0, 0, 0, 20, 40, 70, 70, 150, 300
        }
    }
    */
}