using System;
using System.Collections.Generic;
using System.Linq;

/* 문자열 리스트 str_list에는 "u", "d", "l", "r" 네 개의 문자열이 여러 개 저장되어 있습니다. 
 * 
 * str_list에서 "l"과 "r" 중 먼저 나오는 문자열이 "l"이라면 
 * 해당 문자열을 기준으로 왼쪽에 있는 문자열들을 순서대로 담은 리스트를, 
 * 먼저 나오는 문자열이 "r"이라면 해당 문자열을 기준으로 오른쪽에 있는 문자열들을 
 * 순서대로 담은 리스트를 return하도록 solution 함수를 완성해주세요. 
 * 
 * "l"이나 "r"이 없다면 빈 리스트를 return합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] str_list)
        {
            List<string> answer = new List<string>();

            for (int i = 0; i < str_list.Length; i++)
            {
                //  "l" 먼저, 왼쪽 담음
                if (str_list[i] == "l")
                {
                    answer = str_list.Take(i).ToList();
                    break;
                }
                //  "r" 먼저, 오른쪽 담음
                else if (str_list[i] == "r")
                {
                    answer = str_list.Skip(i + 1).ToList();
                    break;
                }
            }
            //  없으면 빈 리스트
            return answer.Count == 0 ? new string[] { } : answer.ToArray();
        }
    }
    class 왼쪽_오른쪽
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _strList01 = { "u", "u", "l", "r" };
            string[] _strList02 = { "l" };

            foreach (var s in _solution.solution(_strList01))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            foreach (var s in _solution.solution(_strList02))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
