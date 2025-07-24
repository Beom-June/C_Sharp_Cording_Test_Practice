using System;
using System.Collections.Generic;

/* Retry
 * 문자열 my_string이 매개변수로 주어질 때, 
 * my_string 안에 있는 숫자만 골라 오름차순 정렬한 리스트를 
 * return 하도록 solution 함수를 작성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(string my_string)
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < my_string.Length; i++)
            {
                if (Char.IsDigit(my_string[i]))  // 문자가 숫자인지 확인
                {
                    answer.Add(int.Parse(my_string[i].ToString()));  // 숫자로 변환하여 리스트에 추가
                }
            }
            answer.Sort();
            return answer.ToArray();
        }
    }
    class 문자열_정렬하기_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString01 = "hi12392";
            string _myString02 = "p2o4i8gj2";
            string _myString03 = "abcde0";

            foreach (var i in _solution.solution(_myString01))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (var i in _solution.solution(_myString02))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (var i in _solution.solution(_myString03))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
