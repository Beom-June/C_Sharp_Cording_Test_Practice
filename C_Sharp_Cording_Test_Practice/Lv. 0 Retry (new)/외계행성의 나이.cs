using System;
using System.Text;

/* Retry
 * 우주여행을 하던 머쓱이는 엔진 고장으로 PROGRAMMERS-962 행성에 불시착하게 됐습니다. 
 * 
 * 입국심사에서 나이를 말해야 하는데, PROGRAMMERS-962 행성에서는 나이를 알파벳으로 말하고 있습니다. 
 * a는 0, b는 1, c는 2, ..., j는 9입니다. 예를 들어 23살은 cd, 51살은 fb로 표현합니다. 
 * 
 * 나이 age가 매개변수로 주어질 때 PROGRAMMER-962식 나이를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(int age)
        {
            StringBuilder answer = new StringBuilder();
            string _ageString = age.ToString(); // 나이를 문자열로 변환

            foreach (char c in _ageString)
            {
                // 각 숫자를 대응하는 알파벳으로 변환
                answer.Append((char)('a' + (c - '0')));
            }

            return answer.ToString();
        }
    }
    class 외계행성의_나이
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(23));
            Console.WriteLine(_solution.solution(51));
            Console.WriteLine(_solution.solution(100));
        }
    }
    */
}
