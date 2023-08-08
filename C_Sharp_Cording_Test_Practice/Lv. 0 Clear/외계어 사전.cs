using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * PROGRAMMERS-962 행성에 불시착한 우주비행사 머쓱이는 
 * 외계행성의 언어를 공부하려고 합니다.
 * 알파벳이 담긴 배열 spell과 외계어 사전 dic이 매개변수로 주어집니다. 
 * spell에 담긴 알파벳을 한번씩만 모두 사용한 단어가 dic에 존재한다면 1, 
 * 존재하지 않는다면 2를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string[] spell, string[] dic)
        {
            int answer = 0; 
            // Concat : 문자열 연결, OrderBy : 정렬
            string _sortedSpell = string.Concat(spell.OrderBy(z => z));
            // Any: 컬렉션에 원소가 있는지 여부 확인
            bool _anyMatch = dic.Any(x => string.Concat(x.OrderBy(o => o)) == _sortedSpell);
            answer = _anyMatch ? 1 : 2;
            return answer;
        }
    }
    class 외계어_사전
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _spell1 = { "p", "o", "s" };
            string[] _spell2 = { "z", "d", "x" };
            string[] _spell3 = { "s", "o", "m", "d" };

            string[] _dic1 = { "sod", "eocd", "qixm", "adio", "soo" };
            string[] _dic2 = { "def", "dww", "dzx", "loveaw" };
            string[] _dic3 = { "moos", "dzx", "smm", "sunmmo", "som" };

            Console.WriteLine(_solution.solution(_spell1, _dic1));
            Console.WriteLine(_solution.solution(_spell2, _dic2));
            Console.WriteLine(_solution.solution(_spell3, _dic3));
        }
    }
*/
}
