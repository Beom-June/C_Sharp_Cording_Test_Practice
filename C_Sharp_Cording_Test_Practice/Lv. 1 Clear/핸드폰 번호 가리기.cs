﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 프로그래머스 모바일은 개인정보 보호를 위해 
 * 고지서를 보낼 때 고객들의 전화번호의 일부를 가립니다.
 * 
 * 전화번호가 문자열 phone_number로 주어졌을 때, 
 * 전화번호의 뒷 4자리를 제외한 나머지 숫자를 전부 *으로 가린 문자열을 리턴하는 함수, 
 * solution을 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string phone_number)
        {
            string answer = "";
            for (int i = 0; i < phone_number.Length; i++)
            {
                if (i < phone_number.Length - 4)
                {
                    answer += "*";
                }
                else
                {
                    answer += phone_number[i];
                }
            }
            return answer;
        }
    }
    class 핸드폰_번호_가리기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _phone01 = "0103334444";
            string _phone02 = "027778888";

            Console.WriteLine(_solution.solution(_phone01));
            Console.WriteLine(_solution.solution(_phone02));
        }
    }
    */
}
