using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 길이가 같은 문자열 배열 my_strings와 이차원 정수 배열 parts가 매개변수로 주어집니다. 
 * parts[i]는 [s, e] 형태로, my_string[i]의 인덱스 s부터 
 * 인덱스 e까지의 부분 문자열을 의미합니다. 
 * 
 * 각 my_strings의 원소의 parts에 해당하는 부분 문자열을 순서대로 
 * 이어 붙인 문자열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string[] my_strings, int[,] parts)
        {
            string answer = "";
            for (int i = 0; i < parts.GetLength(0); i++)
            {
                int _s = parts[i, 0];
                int _e = parts[i, 1];

                answer += my_strings[i].Substring(_s, _e - _s + 1);
            }
            return answer;
        }
    }
    class 부분_문자열_이어_붙여_문자열_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _my_strings = { "progressive", "hamburger", "hammer", "ahocorasick" };
            int[,] _parts = { { 0, 4 }, { 1, 2 }, { 3, 5 }, { 7, 7 } };

            Console.WriteLine(_solution.solution(_my_strings, _parts));
        }
    }
    */
}
