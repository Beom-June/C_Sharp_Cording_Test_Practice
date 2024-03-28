using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* array의 각 element 중 divisor로 나누어 떨어지는 값을 오름차순으로 
 * 정렬한 배열을 반환하는 함수, solution을 작성해주세요.
 * 
 * divisor로 나누어 떨어지는 element가 하나도 없다면 배열에 -1을 담아 반환하세요.
 * 
 * 제한사항
 * arr은 자연수를 담은 배열입니다.
 * 정수 i, j에 대해 i ≠ j 이면 arr[i] ≠ arr[j] 입니다.
 * divisor는 자연수입니다.
 * array는 길이 1 이상인 배열입니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            List<int> _result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    _result.Add(arr[i]);
                }
            }
            if (_result.Count == 0)
            {
                return new int[] { -1 };
            }
            _result.Sort();

            return _result.ToArray();
        }
    }
    class 나누어_떨어지는_숫자_배열
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr1 = { 5, 9, 7, 10 };
            int[] _arr2 = { 2, 36, 1, 3 };
            int[] _arr3 = { 3, 2, 6 };

            int _div1 = 5;
            int _div2 = 1;
            int _div3 = 10;

            Console.WriteLine(string.Join(", ", _solution.solution(_arr1, _div1)));
            Console.WriteLine(string.Join(", ", _solution.solution(_arr2, _div2)));
            Console.WriteLine(string.Join(", ", _solution.solution(_arr3, _div3)));
        }
    }
    */
}
