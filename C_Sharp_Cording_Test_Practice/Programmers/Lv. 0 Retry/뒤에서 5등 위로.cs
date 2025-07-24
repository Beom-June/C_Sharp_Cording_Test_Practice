using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수로 이루어진 리스트 num_list가 주어집니다. 
 * num_list에서 가장 작은 5개의 수를 제외한 수들을 오름차순으로 담은 리스트를 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            // 배열을 오름차순으로 정렬
            Array.Sort(num_list);

            // 가장 작은 5개의 수를 제외한 나머지 수들을 선택
            int[] _answer = new int[num_list.Length - 5];
            Array.Copy(num_list, 5, _answer, 0, _answer.Length);

            return _answer;
        }
    }
    class 뒤에서_5등_위로
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _num_list = { 12, 4, 15, 46, 38, 1, 14, 56, 32, 10 };

            foreach (var _result in _solution.solution(_num_list))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
