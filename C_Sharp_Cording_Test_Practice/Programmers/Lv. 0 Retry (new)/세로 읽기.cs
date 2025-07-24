using System;
using System.Text;

/* Retry
 * 문자열 my_string과 두 정수 m, c가 주어집니다. 
 * 
 * my_string을 한 줄에 m 글자씩 가로로 적었을 때 
 * 왼쪽부터 세로로 c번째 열에 적힌 글자들을 문자열로 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, int m, int c)
        {
            StringBuilder answer = new StringBuilder();

            //  문자열 나누기 위해 (my_string.Length / m) 번 반복
            for (int i = 0; i < my_string.Length / m; i++)
            {
                // 특정 열의 문자 추출: 각 줄에서 c 번째 열에 해당하는 문자를 추출합니다.
                // c - 1을 사용하는 이유는 배열 인덱스가 0부터 시작하기 때문
                answer.Append(my_string[i * m + (c - 1)]);
            }
            return answer.ToString();
        }
    }
    class 세로_읽기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString01 = "ihrhbakrfpndopljhygc";
            string _myString02 = "programmers";

            Console.WriteLine(_solution.solution(_myString01, 4, 2));
            Console.WriteLine(_solution.solution(_myString02, 1, 1));
        }
    }
    */
}