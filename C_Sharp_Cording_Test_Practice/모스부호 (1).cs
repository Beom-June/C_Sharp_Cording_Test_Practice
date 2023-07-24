using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Cording_Test_Practice
{
    /* 재 공부
    public class Solution
    {
        public string solution(string letter)
        {
            string answer = "";
            string[] mos = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            // Split()은 문자열을 잘라주고 현재 공백을 기준으로 자름
            string[] words = letter.Split(' ');

            foreach (string morseWord in words)
            {
                // 모스부호 배열에서 해당 모스부호의 인덱스를 찾아 해당 인덱스에 해당하는 알파벳을 가져옴
                int index = Array.IndexOf(mos, morseWord);
                char alphabet = (char)(index + 'a');

                answer += alphabet;
            }

            return answer;
        }
    }
    class 모스부호__1_
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _letter1 = ".... . .-.. .-.. ---";
            string _letter2 = ".--. -.-- - .... --- -.";

            Console.WriteLine(_solution.solution(_letter1));
            Console.WriteLine(_solution.solution(_letter2));
        }
    }
    */
}
