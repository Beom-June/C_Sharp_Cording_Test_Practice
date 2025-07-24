using System;
using System.Text;

/* Retry
 * 알파벳 소문자로 이루어진 문자열 myString이 주어집니다. 
 * 
 * 알파벳 순서에서 "l"보다 앞서는 모든 문자를 "l"로 바꾼 문자열을 
 * return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string myString)
        {
            StringBuilder answer = new StringBuilder();
            for (int i = 0; i < myString.Length; i++)
            {
                if(myString[i] < 'l')
                {
                    answer.Append('l');
                }
                else
                {
                    answer.Append(myString[i]);
                }
            }
            return answer.ToString();
        }
    }
    class l로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString01 = "abcdevwxyz";
            string _myString02 = "jjnnllkkmm";

            Console.WriteLine(_solution.solution(_myString01));
            Console.WriteLine(_solution.solution(_myString02));
        }
    }
    */
}