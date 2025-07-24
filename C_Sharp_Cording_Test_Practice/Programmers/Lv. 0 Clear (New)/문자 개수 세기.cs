using System;

/* Retry
 * 알파벳 대소문자로만 이루어진 문자열 my_string이 주어질 때, 
 * my_string에서 'A'의 개수, my_string에서 'B'의 개수,..., my_string에서 'Z'의 개수, 
 * my_string에서 'a'의 개수, my_string에서 'b'의 개수,..., my_string에서 'z'의 개수를 
 * 순서대로 담은 길이 52의 정수 배열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(string my_string)
        {
            // 길이 52의 배열을 생성 (0-25: A-Z, 26-51: a-z)
            int[] answer = new int[52];

            // 문자열의 각 문자에 대해 반복
            foreach (char c in my_string)
            {
                if (c >= 'A' && c <= 'Z')  // 대문자일 경우
                {
                    answer[c - 'A']++;
                }
                else if (c >= 'a' && c <= 'z')  // 소문자일 경우
                {
                    //  아스키 코드 값에서 뺀 값을 26을 더함
                    answer[c - 'a' + 26]++;
                }
            }

            return answer;
        }
    }
    class 문자_개수_세기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            foreach (var i in _solution.solution("Programmers"))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}