using System;
using System.Collections.Generic;
using System.Linq;

/* Retry
 * 정수 배열 arr과 delete_list가 있습니다. 
 * 
 * arr의 원소 중 delete_list의 원소를 모두 삭제하고 
 * 남은 원소들은 기존의 arr에 있던 순서를 유지한 배열을 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int[] delete_list)
        {
            List<int> answer = arr.ToList();

            foreach (var item in delete_list)
            {
                answer.RemoveAll(i => i == item);
            }
            return answer.ToArray();
        }
    }
    class 배열의_원소_삭제하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr01 = { 293, 1000, 395, 678, 94 };
            int[] _arr02 = { 110, 66, 439, 785, 1 };

            int[] _deletList01 = { 94, 777, 104, 1000, 1, 12 };
            int[] _deletList02 = { 377, 823, 119, 43 };

            foreach (var item in _solution.solution(_arr01,_deletList01))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in _solution.solution(_arr02, _deletList02))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    */
}