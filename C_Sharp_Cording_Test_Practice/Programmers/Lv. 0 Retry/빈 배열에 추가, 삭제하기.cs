using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 아무 원소도 들어있지 않은 빈 배열 X가 있습니다. 
 * 길이가 같은 정수 배열 arr과 boolean 배열 flag가 매개변수로 주어질 때, 
 * flag를 차례대로 순회하며 flag[i]가 true라면 X의 뒤에 
 * arr[i]를 arr[i] × 2 번 추가하고, 
 * flag[i]가 false라면 X에서 마지막 arr[i]개의 원소를 제거한 뒤 
 * X를 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, bool[] flag)
        {
            List<int> _answer = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (flag[i] == true)
                {
                    for (int j = 0; j < arr[i] * 2; j++)
                    {
                        _answer.Add(arr[i]);
                    }
                }
                else
                {
                    _answer.RemoveRange(_answer.Count - arr[i], arr[i]);
                }
            }
            return _answer.ToArray();
        }
    }
    class 빈_배열에_추가__삭제하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 3, 2, 4, 1, 3 };
            bool[] _flag = { true, false, true, false, false };

            foreach (var _result in _solution.solution(_arr, _flag))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
