using System;
using System.Collections.Generic;

/* 어떤 문자열에 대해서 접미사는 특정 인덱스부터 시작하는 문자열을 의미합니다. 
 * 
 * 예를 들어, "banana"의 모든 접미사는 "banana", "anana", "nana", "ana", "na", "a"입니다.
 * 
 * 문자열 my_string이 매개변수로 주어질 때, my_string의 
 * 모든 접미사를 사전순으로 정렬한 문자열 배열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string my_string)
        {
            List<string> answer = new List<string>();
            for (int i = 0; i < my_string.Length; i++)
            {
                answer.Add(my_string.Substring(i));
            }
            answer.Sort();
            return answer.ToArray();
        }
    }
    class 접미사_배열
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString01 = "banana";
            string _myString02 = "programmers";

            foreach (var item in _solution.solution(_myString01))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in _solution.solution(_myString02))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
