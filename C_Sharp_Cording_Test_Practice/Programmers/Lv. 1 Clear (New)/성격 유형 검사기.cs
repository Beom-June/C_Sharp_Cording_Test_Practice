﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 나만의 카카오 성격 유형 검사지를 만들려고 합니다.
 * 성격 유형 검사는 다음과 같은 4개 지표로 성격 유형을 구분합니다. 
 * 성격은 각 지표에서 두 유형 중 하나로 결정됩니다.
 * 
 * 지표 번호	성격 유형
 * 1번 지표	라이언형(R), 튜브형(T)
 * 2번 지표	콘형(C), 프로도형(F)
 * 3번 지표	제이지형(J), 무지형(M)
 * 4번 지표	어피치형(A), 네오형(N)
 * 4개의 지표가 있으므로 성격 유형은 총 16(=2 x 2 x 2 x 2)가지가 나올 수 있습니다. 
 * 예를 들어, "RFMN"이나 "TCMA"와 같은 성격 유형이 있습니다.
 * 
 * 검사지에는 총 n개의 질문이 있고, 각 질문에는 아래와 같은 7개의 선택지가 있습니다.
 * 
 * 매우 비동의  | 1
 * 비동의       | 2
 * 약간 비동의  | 3
 * 모르겠음     | 4
 * 약간 동의    | 5
 * 동의         | 6
 * 매우 동의    | 7
 * 각 질문은 1가지 지표로 성격 유형 점수를 판단합니다.
 * 
 * 예를 들어, 어떤 한 질문에서 4번 지표로 아래 표처럼 점수를 매길 수 있습니다.
 * 
 * 선택지      |	성격 유형 점수
 * 매우 비동의 |	네오형 3점
 * 비동의      |	네오형 2점
 * 약간 비동의 |	네오형 1점
 * 모르겠음	  | 어떤 성격 유형도 점수를 얻지 않습니다
 * 약간 동의	  | 어피치형 1점
 * 동의	      | 어피치형 2점
 * 매우 동의	  | 어피치형 3점
 * 이때 검사자가 질문에서 약간 동의 선택지를 선택할 경우 
 * 어피치형(A) 성격 유형 1점을 받게 됩니다. 
 * 만약 검사자가 매우 비동의 선택지를 선택할 경우 네오형(N) 성격 유형 3점을 받게 됩니다.
 * 
 * 위 예시처럼 네오형이 비동의, 어피치형이 동의인 경우만 주어지지 않고, 
 * 질문에 따라 네오형이 동의, 어피치형이 비동의인 경우도 주어질 수 있습니다.
 * 하지만 각 선택지는 고정적인 크기의 점수를 가지고 있습니다.
 * 
 * 매우 동의나 매우 비동의 선택지를 선택하면 3점을 얻습니다.
 * 동의나 비동의 선택지를 선택하면 2점을 얻습니다.
 * 약간 동의나 약간 비동의 선택지를 선택하면 1점을 얻습니다.
 * 모르겠음 선택지를 선택하면 점수를 얻지 않습니다.
 * 검사 결과는 모든 질문의 성격 유형 점수를 더하여 각 지표에서 
 * 더 높은 점수를 받은 성격 유형이 검사자의 성격 유형이라고 판단합니다. 
 * 단, 하나의 지표에서 각 성격 유형 점수가 같으면, 두 성격 유형 중 사전 순으로 
 * 빠른 성격 유형을 검사자의 성격 유형이라고 판단합니다.
 * 
 * 질문마다 판단하는 지표를 담은 1차원 문자열 배열 survey와 검사자가 각 질문마다 
 * 선택한 선택지를 담은 1차원 정수 배열 choices가 매개변수로 주어집니다. 
 * 이때, 검사자의 성격 유형 검사 결과를 지표 번호 순서대로 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice.Programmers
{
    /*
    public class Solution
    {
        public string solution(string[] survey, int[] choices)
        {
            string answer = "";

            // 각 지표에 대한 점수 초기화
            Dictionary<char, int> _scores = new Dictionary<char, int>
            {
                { 'R', 0 }, { 'T', 0 },
                { 'C', 0 }, { 'F', 0 },
                { 'J', 0 }, { 'M', 0 },
                { 'A', 0 }, { 'N', 0 }
            };

            // survey 배열을 문자 배열로 변환
            char[] _firstType = new char[survey.Length];
            char[] _secondType = new char[survey.Length];
            for (int i = 0; i < survey.Length; i++)
            {
                _firstType[i] = survey[i][0];
                _secondType[i] = survey[i][1];
            }

            // survey와 choices 배열을 순회하며 점수 계산
            for (int i = 0; i < survey.Length; i++)
            {
                int choice = choices[i];
                // 선택지에 따라 점수 계산
                if (choice < 4) // 비동의 쪽
                {
                    _scores[_firstType[i]] += 4 - choice; // 1~3에 대해 점수 증가
                }
                else if (choice > 4) // 동의 쪽
                {
                    _scores[_secondType[i]] += choice - 4; // 5~7에 대해 점수 증가
                }
                // choice == 4는 점수를 주지 않음
                else if (choice == 4)
                {
                    _scores[_firstType[i]] += 0; // 아무 점수도 주지 않음
                }
            }

            // 각 지표 쌍마다 점수가 더 높은 성격 유형을 결과 문자열에 추가
            answer += _scores['R'] >= _scores['T'] ? 'R' : 'T';
            answer += _scores['C'] >= _scores['F'] ? 'C' : 'F';
            answer += _scores['J'] >= _scores['M'] ? 'J' : 'M';
            answer += _scores['A'] >= _scores['N'] ? 'A' : 'N';
            return answer;
        }
    }
    internal class 성격_유형_검사기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _survey01 = { "AN", "CF", "MJ", "RT", "NA" };
            string[] _survey02 = { "TR", "RT", "TR" };

            int[] _choices01 = { 5, 3, 2, 7, 5 };       // 약간 동의, 모르겠음, 비동의, 매우 동의, 약간 동의
            int[] _choices02 = { 7, 1, 3 };             // 매우 동의, 매우 비동의, 비동의

            Console.WriteLine(_solution.solution(_survey01, _choices01)); // "TCMA"
            Console.WriteLine(_solution.solution(_survey02, _choices02)); // "RCJA"
        }
    }
    */
}