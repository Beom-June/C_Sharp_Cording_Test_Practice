using System;
using System.Collections.Generic;
using System.Linq;

/* Retry
 * 문자열 배열 strArr이 주어집니다. 
 * strArr의 원소들을 길이가 같은 문자열들끼리 그룹으로 묶었을 때 가장 개수가 많은 그룹의 크기를 
 * return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string[] strArr)
        {
            Dictionary<int, int> lengthCount = new Dictionary<int, int>();

            foreach (string str in strArr)
            {
                int len = str.Length;
                if (lengthCount.ContainsKey(len))
                {
                    lengthCount[len]++;
                }
                else
                {
                    lengthCount[len] = 1;
                }
            }

            int maxGroupSize = lengthCount.Values.Max();
            return maxGroupSize;
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