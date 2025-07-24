using System;

/* Retry
 * 임의의 문자열이 주어졌을 때 문자 "a", "b", "c"를 구분자로 사용해 문자열을 나누고자 합니다.
 * 
 * 예를 들어 주어진 문자열이 "baconlettucetomato"라면 나눠진 
 * 문자열 목록은 ["onlettu", "etom", "to"] 가 됩니다.
 * 
 * 문자열 myStr이 주어졌을 때 위 예시와 같이 "a", "b", "c"를 사용해 
 * 나눠진 문자열을 순서대로 저장한 배열을 return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, 두 구분자 사이에 다른 문자가 없을 경우에는 아무것도 저장하지 않으며, 
 * return할 배열이 빈 배열이라면 ["EMPTY"]를 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string myStr)
        {
            string[] answer = myStr.Split(new char[] { 'a', 'b', 'c' }, StringSplitOptions.RemoveEmptyEntries);

            if (answer.Length == 0)
                return new string[] { "EMPTY" };
            return answer;
        }
    }
    class 세_개의_구분자
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myStr01 = "baconlettucetomato";
            string _myStr02 = "abcd";
            string _myStr03 = "cabab";

            Console.WriteLine(string.Join(", ", _solution.solution(_myStr01)));  // 출력: onlettu, etom, to
            Console.WriteLine(string.Join(", ", _solution.solution(_myStr02)));  // 출력: d
            Console.WriteLine(string.Join(", ", _solution.solution(_myStr03)));  // 출력: 
        }
    }
    */
}