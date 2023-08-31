using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습 Linq
 * 랜덤으로 서로 다른 k개의 수를 저장한 배열을 만드려고 합니다. 
 * 적절한 방법이 떠오르지 않기 때문에 일정한 범위 내에서 무작위로 수를 뽑은 후, 
 * 지금까지 나온적이 없는 수이면 배열 맨 뒤에 추가하는 방식으로 만들기로 합니다.
 * 
 * 이미 어떤 수가 무작위로 주어질지 알고 있다고 가정하고, 
 * 실제 만들어질 길이 k의 배열을 예상해봅시다.
 * 
 * 정수 배열 arr가 주어집니다. 
 * 문제에서의 무작위의 수는 arr에 저장된 순서대로 주어질 예정이라고 했을 때, 
 * 완성될 배열을 return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, 완성될 배열의 길이가 k보다 작으면 나머지 값을 전부 -1로 채워서 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    public class Solution
    {
        public int[] solution(int[] arr, int k)
        {
            HashSet<int> _hashNum = new HashSet<int>();
            List<int> _answer = new List<int>();

            foreach (int _num in arr)
            {
                if (!_hashNum.Contains(_num))
                {
                    _hashNum.Add(_num);
                    _answer.Add(_num);
                }

                if (_answer.Count == k)
                    break;
            }

            while (_answer.Count < k)
            {
                _answer.Add(-1);
            }

            return _answer.ToArray();
        }
    }
    class 무작위로_K개의_수_뽑기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr1 = { 0, 1, 1, 2, 2, 3 };
            int[] _arr2 = { 0, 1, 1, 1, 1 };

            int _k1 = 3, _k2 = 4;

            foreach (var _result in _solution.solution(_arr1, _k1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_arr2, _k2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
}
