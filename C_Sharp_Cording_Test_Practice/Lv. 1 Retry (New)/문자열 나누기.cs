using System;

/* Retry
 * 문자열 s가 입력되었을 때 다음 규칙을 따라서 이 문자열을 여러 문자열로 분해하려고 합니다.
 * 
 * 먼저 첫 글자를 읽습니다. 이 글자를 x라고 합시다.
 * 이제 이 문자열을 왼쪽에서 오른쪽으로 읽어나가면서, x와 x가 아닌 다른 글자들이 나온 횟수를 각각 셉니다. 
 * 처음으로 두 횟수가 같아지는 순간 멈추고, 지금까지 읽은 문자열을 분리합니다.
 * s에서 분리한 문자열을 빼고 남은 부분에 대해서 이 과정을 반복합니다. 남은 부분이 없다면 종료합니다.
 * 만약 두 횟수가 다른 상태에서 더 이상 읽을 글자가 없다면, 역시 지금까지 읽은 문자열을 분리하고, 종료합니다.
 * 문자열 s가 매개변수로 주어질 때, 위 과정과 같이 문자열들로 분해하고, 
 * 분해한 문자열의 개수를 return 하는 함수 solution을 완성하세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            int _xSame = 0; // 기준 문자와 동일한 문자의 개수
            int _notSame = 0; // 기준 문자와 다른 문자의 개수
            char _x = s[0]; // 첫 글자를 기준 문자로 설정

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == _x)
                {
                    _xSame++;
                }
                else
                {
                    _notSame++;
                }

                // 기준 문자와 다른 문자의 개수가 같아지면 문자열 분리
                if (_xSame == _notSame)
                {
                    answer++;
                    _xSame = 0;
                    _notSame = 0;

                    // 기준 문자를 다음 문자로 변경
                    if (i + 1 < s.Length)
                    {
                        _x = s[i + 1];
                    }
                }
            }

            // 남아있는 문자가 있다면 추가로 한 번 더 분리
            if (_xSame != 0 || _notSame != 0)
            {
                answer++;
            }
            return answer;
        }
    }
    class 문자열_나누기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s01 = "banana";
            string _s02 = "abracadabra";
            string _s03 = "aaabbaccccabba";

            Console.WriteLine(_solution.solution(_s01));        //  3
            Console.WriteLine(_solution.solution(_s02));        //  6
            Console.WriteLine(_solution.solution(_s03));        //  3
        }
    }
    */
}