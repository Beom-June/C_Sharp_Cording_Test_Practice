﻿using System;

/* 2016년 1월 1일은 금요일입니다. 
 * 2016년 a월 b일은 무슨 요일일까요? 
 * 두 수 a ,b를 입력받아 2016년 a월 b일이 무슨 요일인지 리턴하는 함수, solution을 완성하세요. 
 * 
 * 요일의 이름은 일요일부터 토요일까지 각각 SUN,MON,TUE,WED,THU,FRI,SAT입니다. 
 * 예를 들어 a=5, b=24라면 5월 24일은 화요일이므로 문자열 "TUE"를 반환하세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(int a, int b)
        {
            string answer = "";
            DateTime _dateValue = new DateTime(2016, a, b);
            answer = _dateValue.DayOfWeek.ToString().Substring(0, 3);
            //answer = _dateValue.DayOfWeek.ToString().Substring(0, 3).ToUpper();
            return answer;
        }
    }
    class _2016년
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(5, 24));
        }
    }
    */
}
