using System;
using System.Collections.Generic;

/* Retry
 * 최빈값은 주어진 값 중에서 가장 자주 나오는 값을 의미합니다. 
 * 
 * 정수 배열 array가 매개변수로 주어질 때, 
 * 최빈값을 return 하도록 solution 함수를 완성해보세요. 
 * 
 * 최빈값이 여러 개면 -1을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] array)
        {
            //  Key 값과 Value 값 잡기
            Dictionary<int, int> _cntDictionary = new Dictionary<int, int>();
            foreach (var i in array)
            {
                if (_cntDictionary.ContainsKey(i))
                    _cntDictionary[i]++;
                else
                    _cntDictionary.Add(i, 1);
            }

            //  다시 foreach로 순회하며 value 값이 가장 높은 것을 찾는다.
            int answer = 0;
            int _cnt = 0;
            foreach (var _pair in _cntDictionary)
            {
                if (_pair.Value > _cnt)
                {
                    _cnt = _pair.Value;
                    answer = _pair.Key;
                }
            }

            //  유일한지 체크
            int _only = 0;
            foreach (var _pair in _cntDictionary)
            {
                if (_cnt == _pair.Value)
                    _only++;
                if (_only > 1)
                    return - 1;
            }
            return answer;
        }
    }
    class 최빈값_구하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr01 = { 1, 2, 3, 3, 4 };
            int[] _arr02 = { 1, 1, 2, 2 };
            int[] _arr03 = { 1 };

            Console.WriteLine(_solution.solution(_arr01));      //  3
            Console.WriteLine(_solution.solution(_arr02));      //  -1
            Console.WriteLine(_solution.solution(_arr03));      //  1

        }
    }
    */
}