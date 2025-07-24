using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 리스트 num_list와 정수 n이 주어질 때, 
 * num_list를 n 번째 원소 이후의 원소들과 n 번째까지의 원소들로 
 * 나눠 n 번째 원소 이후의 원소들을 n 번째까지의 원소들 앞에 붙인 리스트를 
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
                // n 번째 이후의 원소들을 answer 리스트에 추가
                for (int i = n; i < num_list.Length; i++)
                {
                    answer.Add(num_list[i]);
                }

                // n 번째까지의 원소들을 answer 리스트에 추가
                for (int i = 0; i < n; i++)
                {
                    answer.Add(num_list[i]);
                }
            }
            else
            {
                // 유효하지 않은 n일 경우, num_list 그대로 반환
                answer.AddRange(num_list);
            }
            return answer.ToArray();
        }
    }
    class 순서_바꾸기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _num_list1 = { 2, 1, 6 };
            int[] _num_list2 = { 5, 2, 1, 7, 5 };

            int _n1 = 1, _n2 = 3;

            int[] result1 = _solution.solution(_num_list1, _n1);
            int[] result2 = _solution.solution(_num_list2, _n2);

            Console.WriteLine(string.Join(" ", result1)); // 출력 예시: 1 6 2
            Console.WriteLine(string.Join(" ", result2)); // 출력 예시: 7 5 5 2 1
        }
    }
    */
}
