using System;
using System.Collections.Generic;

/* 문자열 배열 strArr가 주어집니다. 
 * 
 * 배열 내의 문자열 중 "ad"라는 부분 문자열을 포함하고 있는 
 * 모든 문자열을 제거하고 남은 문자열을 순서를 유지하여 배열로 
 * return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] strArr)
        {
            List<string> answer = new List<string>();
            for (int i = 0; i < strArr.Length; i++)
            {
                if (!strArr[i].Contains("ad"))
                {
                    answer.Add(strArr[i]);
                }
            }
            return answer.ToArray();
        }
    }
    class ad_제거하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _strArr01 = { "and", "notad", "abcd" };
            string[] _strArr02 = { "there", "are", "no", "a", "ds" };

            foreach (var s in _solution.solution(_strArr01))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            foreach (var s in _solution.solution(_strArr02))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
