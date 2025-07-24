using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 리스트 num_list가 주어질 때, 
 * 마지막 원소가 그전 원소보다 크면 마지막 원소에서 그전 원소를 뺀 값을 
 * 마지막 원소가 그전 원소보다 크지 않다면 마지막 원소를 
 * 두 배한 값을 추가하여 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int[] answer = num_list;
            int lastIdx = num_list.Length - 1;

            int[] num = new int[] { num_list[lastIdx - 1] < num_list[lastIdx] ? num_list[lastIdx] - num_list[lastIdx - 1] : num_list[lastIdx] * 2 };
            return answer.Concat(num).ToArray();
        }
    }
    class 마지막_두_원소
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _num_list1 = { 2, 1, 6 };
            int[] _num_list2 = { 5, 2, 1, 7, 5 };

            foreach (var _num in _solution.solution(_num_list1))
            {
                Console.Write(_num + ", ");
            }
            Console.WriteLine();

            foreach (var _num in _solution.solution(_num_list2))
            {
                Console.Write(_num + ", ");
            }
            Console.WriteLine();
        }
    }
    */
}
