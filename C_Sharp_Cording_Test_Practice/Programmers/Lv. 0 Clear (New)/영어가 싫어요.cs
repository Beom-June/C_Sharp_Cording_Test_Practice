using System;
using System.Collections.Generic;

/* Retry
 * 영어가 싫은 머쓱이는 영어로 표기되어있는 숫자를 수로 바꾸려고 합니다. 
 * 문자열 numbers가 매개변수로 주어질 때, numbers를 정수로 바꿔 return 하도록 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
public class Solution
{
    public long solution(string numbers)
    {
        Dictionary<string, string> _numberChart = new Dictionary<string, string>()
        {
            { "zero", "0" },
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" }
        };

        // 주어진 문자열을 숫자 문자열로 변환
        foreach (var c in _numberChart)
        {
            numbers = numbers.Replace(c.Key, c.Value);
        }

        // 변환된 숫자 문자열을 long 타입으로 변환
        long answer = long.Parse(numbers);

        return answer;
    }
}
class 영어가_싫어요
{
    static void Main(string[] args)
    {
        Solution _solution = new Solution();

        string _numbers01 = "onetwothreefourfivesixseveneightnine";
        string _numbers02 = "onefourzerosixseven";

        Console.WriteLine(_solution.solution(_numbers01));
        Console.WriteLine(_solution.solution(_numbers02));
    }
}
    */
}