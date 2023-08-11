using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 code가 주어집니다.
 * code를 앞에서부터 읽으면서 만약 문자가 "1"이면 mode를 바꿉니다. 
 * mode에 따라 code를 읽어가면서 문자열 ret을 만들어냅니다.
 * mode는 0과 1이 있으며, idx를 0 부터 code의 길이 - 1 까지 1씩 키워나가면서 
 * code[idx]의 값에 따라 다음과 같이 행동합니다.
 * 
 * mode가 0일 때
 * code[idx]가 "1"이 아니면 idx가 짝수일 때만 ret의 맨 뒤에 code[idx]를 추가합니다.
 * code[idx]가 "1"이면 mode를 0에서 1로 바꿉니다.
 * 
 * mode가 1일 때
 * code[idx]가 "1"이 아니면 idx가 홀수일 때만 ret의 맨 뒤에 code[idx]를 추가합니다.
 * code[idx]가 "1"이면 mode를 1에서 0으로 바꿉니다.
 * 문자열 code를 통해 만들어진 문자열 ret를 return 하는 solution 함수를 완성해 주세요.
 * 단, 시작할 때 mode는 0이며, return 하려는 ret가 만약 빈 문자열이라면 대신 "EMPTY"를 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string code)
        {
            string ret = "";
            int _mode = 0; // 초기 모드는 0

            for (int i = 0; i < code.Length; i++)
            {
                if (_mode == 0)
                {
                    // 1이 아니면
                    if (code[i] != '1')
                    {
                        // 짝수일 때
                        if (i % 2 == 0)
                        {
                            ret += code[i];
                        }
                    }
                    // 1이면
                    else
                    {
                        _mode = 1; // 모드 변경
                    }
                }
                else if (_mode == 1)
                {
                    if (code[i] != '1')
                    {
                        if (i % 2 == 1)
                        {
                            ret += code[i];
                        }
                    }
                    else
                    {
                        _mode = 0; // 모드 변경
                    }
                }
            }

            if (ret == "")
            {
                ret = "EMPTY"; // 빈 문자열인 경우
            }

            return ret;
        }
    }
    class 코드_처리하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _code = "abc1abc1abc";

            Console.WriteLine(_solution.solution(_code));
        }
    }
    */
}
