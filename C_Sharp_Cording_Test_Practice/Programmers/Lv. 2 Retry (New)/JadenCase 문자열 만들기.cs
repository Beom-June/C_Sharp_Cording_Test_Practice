using System;

/* Retry
 * JadenCase란 모든 단어의 첫 문자가 대문자이고, 그 외의 알파벳은 소문자인 문자열입니다. 
 * 단, 첫 문자가 알파벳이 아닐 때에는 이어지는 알파벳은 소문자로 쓰면 됩니다. (첫 번째 입출력 예 참고)
 * 문자열 s가 주어졌을 때, s를 JadenCase로 바꾼 문자열을 리턴하는 함수, solution을 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    internal class JadenCase_문자열_만들기
    {
        public class Solution
        {
            public string solution(string s)
            {
                string answer = "";
                bool _isFirst = true; // 단어의 첫 글자인지 여부

                foreach (char c in s)
                {
                    if (c == ' ')
                    {
                        // 공백이면 그대로 추가하고 다음 문자를 첫 글자로 인식
                        answer += c;
                        _isFirst = true;
                    }
                    else
                    {
                        if (_isFirst)
                        {
                            // 첫 글자면 대문자, 알파벳이 아니면 그대로
                            answer += char.ToUpper(c);
                            _isFirst = false;
                        }
                        else
                        {
                            // 나머지는 소문자로
                            answer += char.ToLower(c);
                        }
                    }
                }

                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s01 = "3people unFollowed me";
            string _s02 = "for the last week";

            Console.WriteLine(_solution.solution(_s01));        //  "3people Unfollowed Me"
            Console.WriteLine(_solution.solution(_s02));        //  "For The Last Week"
        }
    }
    */
}