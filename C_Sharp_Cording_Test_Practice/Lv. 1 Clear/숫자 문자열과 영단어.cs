using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 네오와 프로도가 숫자놀이를 하고 있습니다. 
 * 네오가 프로도에게 숫자를 건넬 때 일부 자릿수를 영단어로 바꾼 카드를 건네주면 
 * 프로도는 원래 숫자를 찾는 게임입니다.
 * 
 * 다음은 숫자의 일부 자릿수를 영단어로 바꾸는 예시입니다.
 * 
 * 1478 → "one4seveneight"
 * 234567 → "23four5six7"
 * 10203 → "1zerotwozero3"
 * 이렇게 숫자의 일부 자릿수가 영단어로 바뀌어졌거나, 
 * 혹은 바뀌지 않고 그대로인 문자열 s가 매개변수로 주어집니다. 
 * s가 의미하는 원래 숫자를 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            s = s.Replace("zero", "0");
            s = s.Replace("one", "1");
            s = s.Replace("two", "2");
            s = s.Replace("three", "3");
            s = s.Replace("four", "4");
            s = s.Replace("five", "5");
            s = s.Replace("six", "6");
            s = s.Replace("seven", "7");
            s = s.Replace("eight", "8");
            s = s.Replace("nine", "9");

            answer = int.Parse(s);
            return answer;
        }
    }
    class 숫자_문자열과_영단어
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution("one4seveneight"));        //  1478
            Console.WriteLine(_solution.solution("23four5six7"));           //  234567
            Console.WriteLine(_solution.solution("2three45sixseven"));      //  234567
            Console.WriteLine(_solution.solution("123"));                   //  123
        }
    }
    */
}