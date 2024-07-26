using System;
using System.Collections.Generic;

/* 문자열 myString이 주어집니다. 
 * "x"를 기준으로 해당 문자열을 잘라내 배열을 만든 후 사전순으로 정렬한 배열을 
 * return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, 빈 문자열은 반환할 배열에 넣지 않습니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string myString)
        {
            //  xp 제거
            List<string> answer = new List<string>(myString.Split('x'));
    //  s == "" 요소가 빈 문자열인지 확인
            answer.RemoveAll(s => s == "");
            //  정렬
            answer.Sort();
            return answer.ToArray();
        }
    }
    class 문자열_잘라서_정렬하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString01 = "axbxcxdx";
            string _myString02 = "dxccxbbbxaaaa";

            foreach (var s in _solution.solution(_myString01))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            foreach (var s in _solution.solution(_myString02))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
    */
}