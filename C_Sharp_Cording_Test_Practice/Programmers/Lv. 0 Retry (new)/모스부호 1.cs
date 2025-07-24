using System;
using System.Collections.Generic;
using System.Text;

/* Retry -> 딕셔너리 연습 
 * 머쓱이는 친구에게 모스부호를 이용한 편지를 받았습니다. 
 * 그냥은 읽을 수 없어 이를 해독하는 프로그램을 만들려고 합니다. 
 * 문자열 letter가 매개변수로 주어질 때, letter를 영어 소문자로 바꾼 문자열을 
 * return 하도록 solution 함수를 완성해보세요.
 * 모스부호는 다음과 같습니다.
 * 
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
    /*
    public class Solution
    {
        private readonly Dictionary<string, char> morse = new Dictionary<string, char>
        {
            {".-", 'a'}, {"-...", 'b'}, {"-.-.", 'c'}, {"-..", 'd'}, {".", 'e'},
            {"..-.", 'f'}, {"--.", 'g'}, {"....", 'h'}, {"..", 'i'}, {".---", 'j'},
            {"-.-", 'k'}, {".-..", 'l'}, {"--", 'm'}, {"-.", 'n'}, {"---", 'o'},
            {".--.", 'p'}, {"--.-", 'q'}, {".-.", 'r'}, {"...", 's'}, {"-", 't'},
            {"..-", 'u'}, {"...-", 'v'}, {".--", 'w'}, {"-..-", 'x'}, {"-.--", 'y'},
            {"--..", 'z'}
        };

        public string solution(string letter)
        {
            StringBuilder answer = new StringBuilder();
            string[] morseLetters = letter.Split(' ');

            foreach (string s in morseLetters)
            {
                if (morse.ContainsKey(s))
                {
                    answer.Append(morse[s]);
                }
            }

            return answer.ToString();
        }
    }
    class 모스부호_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _letter01 = ".... . .-.. .-.. ---";
            string _letter02 = ".--. -.-- - .... --- -.";

            Console.WriteLine(_solution.solution(_letter01));       //  "hello"
            Console.WriteLine(_solution.solution(_letter02));       //  "python"
        }
    }
    */
}