using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* n × n 크기의 이차원 배열 arr이 매개변수로 주어질 때, 
 * arr이 다음을 만족하면 1을 아니라면 0을 return 하는 solution 함수를 작성해 주세요
 * 
 * 0 ≤ i, j < n인 정수 i, j에 대하여 arr[i][j] = arr[j][i]
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[,] arr)
        {
            int answer = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] != arr[j, i])
                    {
                        answer = 0;
                        break;
                    }
                }
                if (answer == 0)
                    break;
            }
            return answer;
        }
    }
    class 특별한_이차원_배열_2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _arr1 = { { 5, 192, 33 }, { 192, 72, 95 }, { 33, 95, 999 } };
            int[,] _arr2 = { { 19, 498, 258, 587 }, { 63, 93, 7, 754 }, { 258, 7, 1000, 723 }, { 587, 754, 723, 81 } };

            Console.WriteLine(_solution.solution(_arr1));
            Console.WriteLine(_solution.solution(_arr2));
        }
    }
    */
}
