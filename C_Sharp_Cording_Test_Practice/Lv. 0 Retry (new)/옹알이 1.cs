using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 머쓱이는 태어난 지 6개월 된 조카를 돌보고 있습니다. 
 * 조카는 아직 "aya", "ye", "woo", "ma" 
 * 네 가지 발음을 최대 한 번씩 사용해 조합한(이어 붙인) 발음밖에 하지 못합니다. 
 * 문자열 배열 babbling이 매개변수로 주어질 때, 
 * 머쓱이의 조카가 발음할 수 있는 단어의 개수를 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string[] babbling)
        {
            int answer = 0;
            string[] _canBab = { "aya", "ye", "woo", "ma" };

            foreach (var s in babbling)
            {
                string _temp = s;

                foreach (string speak in _canBab)
                {
                    // 만약 이전 발음과 현재 발음이 같으면 break (중복 사용 방지)
                    if (_temp.Contains(speak + speak))
                        break;

                    // 발음 제거
                    _temp = _temp.Replace(speak, " ");
                }

                // 공백만 남았으면 유효한 단어
                if (_temp.Trim() == "")
                {
                    answer++;
                }
            }
            return answer;
        }
    }
    internal class 옹알이_1
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _babbling01 = { "aya", "yee", "u", "maa", "wyeoo" };
            string[] _babbling02 = { "ayaye", "uuuma", "ye", "yemawoo", "ayaa" };

            Console.WriteLine(_solution.solution(_babbling01));       //  1
            Console.WriteLine(_solution.solution(_babbling02));       //  3
        }
    }
    */
}