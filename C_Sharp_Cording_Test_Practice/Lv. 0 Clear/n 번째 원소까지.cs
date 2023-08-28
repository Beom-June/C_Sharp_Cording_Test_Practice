using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 리스트 num_list와 정수 n이 주어질 때, 
 * num_list의 첫 번째 원소부터 n 번째 원소까지의 모든 원소를 담은 리스트를 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] num_list, int n)
        {
            List<int> answer = new List<int>();

            // n이 유효한 범위인지 확인
            if (n >= 1 && n <= num_list.Length)
            {
                // 첫 번째 원소부터 n 번째 원소까지를 answer 리스트에 추가
                for (int i = 0; i < n; i++)
                {
                    answer.Add(num_list[i]);
                }
            }

            return answer.ToArray();
        }
    }
    class n_번째_원소까지
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _num_list1 = { 2, 1, 6 };
            int[] _num_list2 = { 5, 2, 1, 7, 5 };

            int _n1 = 1, _n2 = 3;

            int[] result1 = _solution.solution(_num_list1, _n1);
            int[] result2 = _solution.solution(_num_list2, _n2);

            Console.WriteLine(string.Join(" ", result1));
            Console.WriteLine(string.Join(" ", result2));
        }
    }
    */
}
