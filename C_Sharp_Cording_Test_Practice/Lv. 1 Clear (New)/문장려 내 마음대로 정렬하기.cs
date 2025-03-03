using System;
using System.Linq;

/* 문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때, 
 * 각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬하려 합니다. 
 * 
 * 예를 들어 strings가 ["sun", "bed", "car"]이고 n이 1이면 
 * 각 단어의 인덱스 1의 문자 "u", "e", "a"로 strings를 정렬합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            // n번째 글자를 기준으로 정렬하고, 동일한 경우 사전순으로 정렬
            //  ThenBy(s => s). n번째 문자가 같은 경우, 문자열을 전체 사전순으로 추가 정렬
            var answer = strings.OrderBy(s => s[n]).ThenBy(s => s).ToArray();
            return answer;
        }
    }
    class 문장려_내_마음대로_정렬하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _strings01 = { "sun", "bed", "car" };
            string[] _strings02 = { "abce", "abcd", "cdx" };

            //  "car", "bed", "sun"
            foreach (var s in _solution.solution(_strings01, 1))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            //  "abcd", "abce", "cdx"
            foreach (var s in _solution.solution(_strings02, 2))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
    */
}