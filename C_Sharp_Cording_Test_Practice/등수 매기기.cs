using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[,] score)
        {
            int[] answer = new int[score.GetLength(0)];
            Array.Fill(answer, 1);

            for (int i = 0; i < score.GetLength(0); i++)
            {
                for (int j = 0; j < score.GetLength(0); j++)
                {
                    if (score[i, 0] + score[i, 1] > score[j, 0] + score[j, 1])
                    {
                        answer[j]++;
                    }
                }
            }
            return answer;
        }
    }
    class 등수_매기기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _score1 = { { 80, 70 }, { 90, 50 }, { 40, 70 }, { 50, 80 } };
            int[,] _score2 = { { 80, 70 }, { 70, 80 }, { 30, 50 }, { 90, 100 }, { 100, 90 }, { 100, 100 }, { 10, 30 } };

            Console.WriteLine("Result 1:");
            foreach (var rank in _solution.solution(_score1))
            {
                Console.Write(rank + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Result 2:");
            foreach (var rank in _solution.solution(_score2))
            {
                Console.Write(rank + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
