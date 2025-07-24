using System;

/* 문자열 배열 strArr가 주어집니다. 
 * 
 * 모든 원소가 알파벳으로만 이루어져 있을 때, 
 * 배열에서 홀수번째 인덱스의 문자열은 모든 문자를 대문자로, 
 * 짝수번째 인덱스의 문자열은 모든 문자를 소문자로 바꿔서 반환하는 
 * solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] strArr)
        {
            string[] answer = new string[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    answer[i] = strArr[i].ToLower();
                }
                else
                {
                    answer[i] = strArr[i].ToUpper();
                }
            }
            return answer;
        }
    }
    class 배열에서_문자열_대소문자_변환하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _strArr01 = { "AAA", "BBB", "CCC", "DDD" };
            string[] _strArr02 = { "aBc", "AbC" };

            foreach (var item in _solution.solution(_strArr01))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in _solution.solution(_strArr02))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
