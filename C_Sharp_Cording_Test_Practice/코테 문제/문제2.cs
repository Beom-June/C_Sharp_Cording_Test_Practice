using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 알파벳 소문자로 이루어진 문자열 s
 * 이 문자열을 n번 이하로 분할 가능할 때, 분할된 각 문자열에서 가장 많은 알파벳의 등장 횟수중 최댓값을 최소화하려고 함
 * 분할된 부분 문자열 길이가 1 이상이어야 함
 * 
 * 예를 들어 문자열 s가 "aabbbabba"이고 분할 가능한 횟수 n이 2인 경우
 * ["aabb", "bab", "ba"] 로 문자열을 분할 할 수 있음
 * 
 * 첫 번째 문자열에서 가장 많은 알파벳은 a와 b로, 각각 2번 등장
 * 두 번째 문자열에서 가장 많은 알파벳은 b로, 2번 등장
 * 세 번째 문자열에서 가장 많은 알파벳은 a와 b로, 각각 1번 등장
 * 
 * 위와 같이 문자열을 분할 하면 각 문장려에서 가장 많은 알파벳의 등장 횟수 중 최댓값은 2이며, 어떤 방법으로도 2보다 작게 만들 수 없음
 * 다음과 같이 분할하는 방법 또한 정답이 될 수 있음 : ["aab", "bba", "bba"];
 * 
 * 문자열 s와 분할 간으 횟수를 나타내는 정수 n이 매개 변수로 주어진다. 분할된 각 문자열에서 가장 많은 알파벳의 등장 횟수중 최댓값을 최소화 하도록
 * 문자열을 분할 했을 떄, 이 값을 return하는 Solution 함수를 완성
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class 문제2
    {
        public class Solution
        {
            public int solution(string s, int n)
            {
                int answer = 0;
                List<string> _stringList = new List<string>();

                for (int i = 2; i < s.Length; i++)
                {
                    if (_stringList[i] != _stringList[i + 1])
                        answer++;
                }

                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s01 = "aabbbabba";
            string _s02 = "xyyyyxxxxxx";
            string _s03 = "abcd";

            Console.WriteLine(_solution.solution(_s01, 2));     //  2
            Console.WriteLine(_solution.solution(_s02, 2));     //  3
            Console.WriteLine(_solution.solution(_s03, 1));     //  1
        }
    }
    */
}
