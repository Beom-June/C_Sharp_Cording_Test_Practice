﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 군 전략가 머쓱이는 전쟁 중 적군이 다음과 같은 암호 체계를 사용한다는 것을 알아냈습니다.
 * 암호화된 문자열 cipher를 주고받습니다.
 * 그 문자열에서 code의 배수 번째 글자만 진짜 암호입니다.
 * 문자열 cipher와 정수 code가 매개변수로 주어질 때 
 * 해독된 암호 문자열을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string cipher, int code)
        {
            string answer = "";

            for (int i = 0; i < cipher.Length; i++)
            {
                if ((i + 1) % code == 0)
                    answer += cipher[i];
            }
            return answer;
        }
    }
    class 암호_해독
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _cipher1 = "dfjardstddetckdaccccdegk";
            string _cipher2 = "pfqallllabwaoclk";

            Console.WriteLine(_solution.solution(_cipher1, 4));
            Console.WriteLine(_solution.solution(_cipher2, 2));
        }
    }
    */
}
