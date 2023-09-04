using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습 linq
 * 정수 배열 arr과 delete_list가 있습니다. 
 * arr의 원소 중 delete_list의 원소를 모두 삭제하고 남은 원소들은 
 * 기존의 arr에 있던 순서를 유지한 배열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int[] delete_list)
        {
            // 삭제할 원소를 HashSet으로 만듭니다.
            HashSet<int> _delete = new HashSet<int>(delete_list);

            // 남은 원소를 필터링하여 새로운 배열을 생성합니다.
            int[] _answer = arr.Where(x => !_delete.Contains(x)).ToArray();

            return _answer;
        }
    }
    class 배열의_원소_삭제하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr1 = { 293, 1000, 395, 678, 94 };
            int[] _arr2 = { 110, 66, 439, 785, 1 };

            int[] _delete_list1 = { 94, 777, 104, 1000, 1, 12 };
            int[] _delete_list2 = { 377, 823, 119, 43 };

            foreach (var _result in _solution.solution(_arr1, _delete_list1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_arr2, _delete_list2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
