using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 정수 배열 num_list와 정수 n이 매개변수로 주어집니다. 
 * num_list를 다음 설명과 같이 2차원 배열로 바꿔 return하도록 solution 함수를 완성해주세요.
 * num_list가 [1, 2, 3, 4, 5, 6, 7, 8] 로 길이가 8이고 n이 2이므로 
 * num_list를 2 * 4 배열로 다음과 같이 변경합니다. 2차원으로 바꿀 때에는 
 * num_list의 원소들을 앞에서부터 n개씩 나눠 2차원 배열로 변경합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[,] solution(int[] num_list, int n)
        {
            int[,] answer = new int[num_list.Length / n, n];
            for (int i = 0; i < num_list.Length / n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // 저장
                    answer[i, j] = num_list[i * n + j];
                }
            }

            return answer;
        }
    }
    class _2차원으로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _num_list1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] _num_list2 = { 100, 95, 2, 4, 5, 6, 18, 33, 948 };

            int _n1 = 2;
            int _n2 = 3;

            // 출력부
            int[,] result1 = _solution.solution(_num_list1, _n1);
            for (int i = 0; i < _num_list1.Length / _n1; i++)
            {
                for (int j = 0; j < _n1; j++)
                {
                    Console.Write(result1[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] result2 = _solution.solution(_num_list2, _n2);
            for (int i = 0; i < _num_list2.Length / _n2; i++)
            {
                for (int j = 0; j < _n2; j++)
                {
                    Console.Write(result2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    */
}
