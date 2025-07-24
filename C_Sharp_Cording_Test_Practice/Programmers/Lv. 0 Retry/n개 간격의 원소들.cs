using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 리스트 num_list와 정수 n이 주어질 때, 
 * num_list의 첫 번째 원소부터 마지막 원소까지 n개 간격으로 
 * 저장되어있는 원소들을 차례로 담은 리스트를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] num_list, int n)
        {
            int[] answer = new int[(num_list.Length + n - 1) / n]; // 계산된 배열 크기

            int idx = 0;
            for (int i = 0; i < num_list.Length; i += n)
            {
                answer[idx] = num_list[i];
                idx++;
            }
            return answer;
        }
    }
    class n개_간격의_원소들
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _num_list1 = { 4, 2, 6, 1, 7, 6 };
            int[] _num_list2 = { 4, 2, 6, 1, 7, 6 };

            int _n1 = 2;
            int _n2 = 4;

            foreach (var _num in _solution.solution(_num_list1, _n1))
            {
                Console.Write(_num + " ");
            }
            Console.WriteLine();

            foreach (var _num in _solution.solution(_num_list2, _n2))
            {
                Console.Write(_num + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
