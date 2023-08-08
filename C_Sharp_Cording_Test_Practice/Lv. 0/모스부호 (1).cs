using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 복습
/* 머쓱이는 친구에게 모스부호를 이용한 편지를 받았습니다. 
 * 그냥은 읽을 수 없어 이를 해독하는 프로그램을 만들려고 합니다. 
 * 문자열 letter가 매개변수로 주어질 때, letter를 영어 소문자로 바꾼 
 * 문자열을 return 하도록 solution 함수를 완성해보세요.
 * 모스부호는 다음과 같습니다.
 * morse = { 
    '.-':'a','-...':'b','-.-.':'c','-..':'d','.':'e','..-.':'f',
    '--.':'g','....':'h','..':'i','.---':'j','-.-':'k','.-..':'l',
    '--':'m','-.':'n','---':'o','.--.':'p','--.-':'q','.-.':'r',
    '...':'s','-':'t','..-':'u','...-':'v','.--':'w','-..-':'x',
    '-.--':'y','--..':'z'
}
 */
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
