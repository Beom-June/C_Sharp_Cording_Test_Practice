using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 영어가 싫은 머쓱이는 영어로 표기되어있는 숫자를 수로 바꾸려고 합니다. 
 * 문자열 numbers가 매개변수로 주어질 때,
 * numbers를 정수로 바꿔 return 하도록 solution 함수를 완성해 주세요.
 */

namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public long solution(string numbers)
        {
            long answer = 0;

            // 각 케이스를 문자열 배열로 생성
            string[] numToStr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // numToStr의 길이만큼 반복
            for (int i = 0; i < numToStr.Length; i++)
            {
                // numToStr[i]와 해당하는 문자열이 있으면 i로 치환
                numbers = numbers.Replace(numToStr[i], i.ToString());
            }

            // 결과값 (string)을 long 타입으로 변환
            answer = long.Parse(numbers);

            return answer;
        }
    }
    class 영어가_싫어요
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _numbers1 = "onetwothreefourfivesixseveneightnine";
            string _numbers2 = "onefourzerosixseven";

            Console.WriteLine(_solution.solution(_numbers1));
            Console.WriteLine(_solution.solution(_numbers2));
        }
    }
    */
}
