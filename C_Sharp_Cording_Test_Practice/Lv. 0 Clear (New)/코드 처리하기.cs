﻿using System;
using System.Collections.Generic;
using System.Text;
/* 문자열 code가 주어집니다.
 * code를 앞에서부터 읽으면서 만약 문자가 "1"이면 mode를 바꿉니다. 
 * mode에 따라 code를 읽어가면서 문자열 ret을 만들어냅니다.
 * 
 * mode는 0과 1이 있으며, idx를 0 부터 code의 길이 
 * - 1 까지 1씩 키워나가면서 code[idx]의 값에 따라 다음과 같이 행동합니다.
 * 
 * mode가 0일 때
 * code[idx]가 "1"이 아니면 idx가 짝수일 때만 ret의 맨 뒤에 code[idx]를 추가합니다.
 * code[idx]가 "1"이면 mode를 0에서 1로 바꿉니다.
 * mode가 1일 때
 * code[idx]가 "1"이 아니면 idx가 홀수일 때만 ret의 맨 뒤에 code[idx]를 추가합니다.
 * code[idx]가 "1"이면 mode를 1에서 0으로 바꿉니다.
 * 문자열 code를 통해 만들어진 문자열 ret를 return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, 시작할 때 mode는 0이며, return 하려는 ret가 만약 
 * 빈 문자열이라면 대신 "EMPTY"를 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string code)
        {
            StringBuilder answer = new StringBuilder();
            int _mode = 0;

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '1')
                {
                    _mode = 1 - _mode; // 모드 전환 (0 -> 1, 1 -> 0)
                }
                else
                {
                    // mode에 따라 인덱스 조건을 다르게 적용
                    if (_mode == 0 && i % 2 == 0)
                    {
                        answer.Append(code[i]);
                    }
                    else if (_mode == 1 && i % 2 != 0)
                    {
                        answer.Append(code[i]);
                    }
                }
            }
            return answer.Length == 0 ? "EMPTY" : answer.ToString();
        }
    }
    class 코드_처리하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution("abc1abc1abc")); // "acbac"
        }
    }
    */
}