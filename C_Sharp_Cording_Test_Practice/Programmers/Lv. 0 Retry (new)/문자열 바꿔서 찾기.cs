using System;

/* Retry
 * 문자 "A"와 "B"로 이루어진 문자열 myString과 pat가 주어집니다. 
 * 
 * myString의 "A"를 "B"로, "B"를 "A"로 바꾼 문자열의 연속하는 부분 문자열 중 
 * pat이 있으면 1을 아니면 0을 return 하는 solution 함수를 완성하세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string myString, string pat)
        {
            //int answer = 0;
            //myString.Replace("A", "B").Replace("B", "A");
            //if(pat == myString)
            //{
            //    answer = 0;
            //}
            //else
            //{
            //    answer = 1;
            //}
            //return answer;
            // 1단계: 'A'를 임시 문자 'X'로 변환
            string tempString = myString.Replace("A", "X");

            // 2단계: 'B'를 'A'로 변환
            tempString = tempString.Replace("B", "A");

            // 3단계: 임시 문자 'X'를 'B'로 변환
            tempString = tempString.Replace("X", "B");

            // 4단계: 변환된 문자열에 pat가 포함되는지 확인
            if (tempString.Contains(pat))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    class 문자열_바꿔서_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString01 = "ABBAA";
            string _myString02 = "ABAB";

            string _pat01 = "AABB";
            string _pat02 = "ABAB";

            Console.WriteLine(_solution.solution(_myString01, _pat01));     //  1
            Console.WriteLine(_solution.solution(_myString02, _pat02));     //  0
        }
    }
    */
}
