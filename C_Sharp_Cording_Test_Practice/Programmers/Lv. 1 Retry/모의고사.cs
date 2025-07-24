using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 수포자는 수학을 포기한 사람의 준말입니다. 수포자 삼인방은 모의고사에 수학 문제를 전부 찍으려 합니다. 
 * 수포자는 1번 문제부터 마지막 문제까지 다음과 같이 찍습니다.
 * 
 * 1번 수포자가 찍는 방식: 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, ...
 * 2번 수포자가 찍는 방식: 2, 1, 2, 3, 2, 4, 2, 5, 2, 1, 2, 3, 2, 4, 2, 5, ...
 * 3번 수포자가 찍는 방식: 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, ...
 * 
 * 1번 문제부터 마지막 문제까지의 정답이 순서대로 들은 배열 answers가 주어졌을 때, 
 * 가장 많은 문제를 맞힌 사람이 누구인지 배열에 담아 return 하도록 solution 함수를 작성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] answers)
        {
            //int[] answer = new int[] { };
            int[] _case01 = new int[] { 1, 2, 3, 4, 5 };
            int[] _case02 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] _case03 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] _score = new int[3] { 0, 0, 0 };              //  정답 개수 저장 배열 

            int _max = 0;           //  가장 많은 문제를 맞힌 사람의 정답 개수
            List<int> answer = new List<int>();     //  가장 많은 문제를 맞힌 사람들을 저장할 리스트

            //  각 수포자들이 정답을 맞췄는지 확인하고, 정답 개수를 카운트
            for (int i = 0; i < answers.Length; i++)
            {
                if (_case01[i % 5] == answers[i])
                    _score[0]++;
                if (_case02[i % 8] == answers[i])
                    _score[1]++;
                if (_case03[i % 10] == answers[i])
                    _score[2]++;
            }

            for (int i = 0; i < 3; i++)
            {
                if (_max < _score[i])
                    _max = _score[i];
            }
            // 가장 많은 문제를 맞힌 사람을 리스트에 추가
            for (int i = 0; i < 3; i++)
            {
                if (_max == _score[i])
                    answer.Add(i + 1);
            }

            return answer.ToArray();
        }
    }
    class 모의고사
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _answers01 = { 1, 2, 3, 4, 5 };
            int[] _answers02 = { 1, 3, 2, 4, 2 };

            Console.WriteLine(String.Join(",", _solution.solution(_answers01)));        //  1
            Console.WriteLine(String.Join(",", _solution.solution(_answers02)));        //  1,2,3
        }
    }
    */
}