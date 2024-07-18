using System;

/* Retry
 * 길이가 같은 문자열 배열 my_strings와 이차원 정수 배열 parts가 매개변수로 주어집니다. 
 * parts[i]는 [s, e] 형태로, my_string[i]의 인덱스 s부터 인덱스 e까지의 부분 문자열을 의미합니다. 
 * 
 * 각 my_strings의 원소의 parts에 해당하는 부분 문자열을 순서대로 이어 붙인 문자열을 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string[] my_strings, int[,] parts)
        {
            string answer = "";
            for (int i = 0; i < my_strings.Length; i++)
            {
//                i   my_strings[i]   parts[i, 0](start)    parts[i, 1](end)   부분 문자열
//                0   progressive             0                    4             "progr"
//                1   hamburger               1                    2              "am"
//                2   hammer                  3                    5              "mer"
//                3   ahocorasick             7                    7               "c"
                int _start = parts[i, 0];
                int _end = parts[i, 1];

                answer += my_strings[i].Substring(_start, _end - _start + 1);
            }
            return answer;
        }
    }
    class 부분_문자열_이어_붙여_문자열_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _myStrings = { "progressive", "hamburger", "hammer", "ahocorasick" };
            int[,] _parts = { { 0, 4 }, { 1, 2 }, { 3, 5 }, { 7, 7 } };

            Console.WriteLine(_solution.solution(_myStrings, _parts));

            foreach (var item in _solution.solution(_myStrings, _parts))
            {
                Console.Write(item + "");
            }
            Console.WriteLine();
        }
    }
    */
}
