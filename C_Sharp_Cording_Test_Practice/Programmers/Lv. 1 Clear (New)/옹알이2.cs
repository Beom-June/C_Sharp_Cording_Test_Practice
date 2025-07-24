using System;

/* 머쓱이는 태어난 지 11개월 된 조카를 돌보고 있습니다. 
 * 조카는 아직 "aya", "ye", "woo", "ma" 네 가지 발음과 네 가지 발음을 조합해서 
 * 만들 수 있는 발음밖에 하지 못하고 연속해서 같은 발음을 하는 것을 어려워합니다. 
 * 문자열 배열 babbling이 매개변수로 주어질 때, 
 * 머쓱이의 조카가 발음할 수 있는 단어의 개수를 return하도록 solution 함수를 완성해주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string[] babbling)
        {
            int answer = 0;
            string _str = "";
            for (int i = 0; i < babbling.Length; i++)
            {
                // 각 발음을 숫자로 치환합니다.
                babbling[i] = babbling[i].Replace("aya", "1");
                babbling[i] = babbling[i].Replace("ye", "2");
                babbling[i] = babbling[i].Replace("woo", "3");
                babbling[i] = babbling[i].Replace("ma", "4");

                // 같은 발음이 연속되는 경우를 표시하기 위해 'x'로 치환합니다.
                babbling[i] = babbling[i].Replace("11", "x");
                babbling[i] = babbling[i].Replace("22", "x");
                babbling[i] = babbling[i].Replace("33", "x");
                babbling[i] = babbling[i].Replace("44", "x");

                // 'x'를 제거한 문자열이 비어 있는 경우, 조카가 발음할 수 있는 단어입니다.
                _str = babbling[i].Replace("1", string.Empty).Replace("2", string.Empty).Replace("3", string.Empty).Replace("4", string.Empty);

                if (_str == "")
                {
                    answer++;
                }
            }
            return answer;
        }
    }
    class 옹알이2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _babbling01 = { "aya", "yee", "u", "maa" };
            string[] _babbling02 = { "ayaye", "uuu", "yeye", "yemawoo", "ayaayaa" };

            Console.WriteLine(_solution.solution(_babbling01));     //  1
            Console.WriteLine(_solution.solution(_babbling02));     //  2
        }
    }
    */
}