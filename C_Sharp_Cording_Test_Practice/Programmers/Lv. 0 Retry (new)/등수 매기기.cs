using System;

/* Retry
 * 영어 점수와 수학 점수의 평균 점수를 기준으로 학생들의 등수를 매기려고 합니다. 
 * 영어 점수와 수학 점수를 담은 2차원 정수 배열 score가 주어질 때, 
 * 영어 점수와 수학 점수의 평균을 기준으로 매긴 등수를 담은 배열을 
 * return하도록 solution 함수를 완성해주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[,] score)
        {
            double[] _avg = new double[score.GetLength(0)];
            int[] _ranks = new int[score.GetLength(0)];

            // 평균 계산
            for (int i = 0; i < score.GetLength(0); i++)
            {
                _avg[i] = (score[i, 0] + score[i, 1]) / 2.0;
            }

            // 등수 매기기
            for (int i = 0; i < score.GetLength(0); i++)
            {
                int _rank = 1;
                for (int j = 0; j < score.GetLength(0); j++)
                {
                    if (_avg[j] > _avg[i])
                    {
                        _rank++;
                    }
                }
                _ranks[i] = _rank;
            }

            return _ranks;
        }
    }
    class 등수_매기기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _score01 = { { 80, 70 }, { 90, 50 }, { 40, 70 }, { 50, 80 } };
            int[,] _score02 = { { 80, 70 }, { 70, 80 }, { 30, 50 }, { 90, 100 }, { 100, 90 }, { 100, 100 }, { 10, 30 } };

            foreach (var result in _solution.solution(_score01))
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();

            foreach (var result in _solution.solution(_score02))
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
