using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 start_num와 end_num가 주어질 때, 
 * start_num부터 end_num까지의 숫자를 차례로 담은 리스트를 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    public class Solution
    {
        public int[] solution(int start_num, int end_num)
        {
            List<int> answer = new List<int>();
            for (int i = start_num; i <= end_num; i++)
            {
                answer.Add(i);
            }
            return answer.ToArray();
        }
    }
    class 카운트_업
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            foreach (var item in _solution.solution(3, 10))
            {
                Console.Write(item + " ");
            }
        }
    }
}
