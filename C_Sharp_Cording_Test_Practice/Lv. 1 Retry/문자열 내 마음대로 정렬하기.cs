using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때, 
 * 각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬하려 합니다. 
 * 예를 들어 strings가 ["sun", "bed", "car"]이고 n이 1이면 
 * 각 단어의 인덱스 1의 문자 "u", "e", "a"로 strings를 정렬합니다.
 * 
 * 제한 조건
 * strings는 길이 1 이상, 50이하인 배열입니다.
 * strings의 원소는 소문자 알파벳으로 이루어져 있습니다.
 * strings의 원소는 길이 1 이상, 100이하인 문자열입니다.
 * 모든 strings의 원소의 길이는 n보다 큽니다.
 * 인덱스 1의 문자가 같은 문자열이 여럿 일 경우, 사전순으로 앞선 문자열이 앞쪽에 위치합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];

            //  문자열 저장
            for (int i = 0; i < strings.Length; i++)
            {
                //  문자열 배열인 `strings`에서 각 문자열을 선택한 후에
                //  해당 문자열의 인덱스 `n`에 위치한 문자를 선택하는 것
                answer[i] = (strings[i][n]) + strings[i];
            }

            //  정렬
            Array.Sort(answer);

            //  정렬된 문자열에 더했던 n번째 글자를 Substring(1)으로 제거
            for (int j = 0; j < strings.Length; j++)
            {
                answer[j] = answer[j].Substring(1);
            }
            return answer;
        }
    }
    class 문자열_내_마음대로_정렬하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _strings01 = { "sun", "bed", "car" };
            string[] _strings02 = { "abce", "abcd", "cdx" };

            Console.WriteLine(String.Join(", ", _solution.solution(_strings01, 1)));    //  "car", "bed", "sun"
            Console.WriteLine(String.Join(", ", _solution.solution(_strings02, 2)));    //  "abcd", "abce", "cdx"
        }
    }
    */
}