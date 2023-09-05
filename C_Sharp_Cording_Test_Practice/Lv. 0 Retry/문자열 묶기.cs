using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 배열 strArr이 주어집니다. 
 * strArr의 원소들을 길이가 같은 문자열들끼리 그룹으로 묶었을 때 
 * 가장 개수가 많은 그룹의 크기를 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string[] strArr)
        {
            Dictionary<int, List<string>> _lengthGroups = new Dictionary<int, List<string>>();

            // 문자열을 길이에 따라 그룹화
            foreach (string _str in strArr)
            {
                int length = _str.Length;

                if (!_lengthGroups.ContainsKey(length))
                {
                    _lengthGroups[length] = new List<string>();
                }

                _lengthGroups[length].Add(_str);
            }

            int _maxGroupSize = 0;

            // 가장 큰 그룹의 크기 구하기
            foreach (List<string> group in _lengthGroups.Values)
            {
                if (group.Count > _maxGroupSize)
                {
                    _maxGroupSize = group.Count;
                }
            }
            return _maxGroupSize;
        }
    }
    class 문자열_묶기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _strArr = { "a", "bc", "d", "efg", "hi" };

            Console.WriteLine(_solution.solution(_strArr));
        }
    }
    */
}
