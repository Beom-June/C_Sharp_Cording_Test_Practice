using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 머쓱이는 태어난 지 6개월 된 조카를 돌보고 있습니다. 
 * 조카는 아직 "aya", "ye", "woo", "ma" 네 가지 발음을 최대 한 번씩 사용해 
 * 조합한(이어 붙인) 발음밖에 하지 못합니다. 문자열 배열 babbling이 매개변수로 주어질 때, 
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
                // babbling[i]를 Replace()로 문자열이 있을시 그 문자열을 "x"로 변환
                babbling[i] = babbling[i].Replace("aya", "x");
                babbling[i] = babbling[i].Replace("ye", "x");
                babbling[i] = babbling[i].Replace("woo", "x");
                babbling[i] = babbling[i].Replace("ma", "x");

                // babbling[i]를 Replace()로 "x"를 string.Empty로 초기화 
                _str = babbling[i].Replace("x", string.Empty);

                // 발음 가능한 문자일시 str은 공백이므로 answer값 증가
                if (_str == "")
                {
                    answer++;
                }
            }
            return answer;
        }
    }
    class 옹알이__1_
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _babbling1 = { "aya", "yee", "u", "maa", "wyeoo" };
            string[] _babbling2 = { "ayaye", "uuuma", "ye", "yemawoo", "ayaa" };

            Console.WriteLine(_solution.solution(_babbling1));
            Console.WriteLine(_solution.solution(_babbling2));
        }
    }
    */
}
