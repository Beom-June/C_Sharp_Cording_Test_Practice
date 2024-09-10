using System;
using System.Linq;

/* PROGRAMMERS-962 행성에 불시착한 우주비행사 머쓱이는 외계행성의 언어를 공부하려고 합니다. 
 * 
 * 알파벳이 담긴 배열 spell과 외계어 사전 dic이 매개변수로 주어집니다. 
 * spell에 담긴 알파벳을 한번씩만 모두 사용한 단어가 dic에 존재한다면 1, 존재하지 않는다면 2를 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string[] spell, string[] dic)
        {
            // spell 배열의 알파벳을 정렬한 후 문자열로 변환
            // Concat : 여러 문자열을 하나의 문자열로 연결할 때 사용
            //  OrderBy : 정렬
            string _concatSpell = string.Concat(spell.OrderBy(c => c));

            // dic 배열의 각 단어에 대해 정렬 후 spell과 비교
            foreach (var word in dic)
            {
                // 단어를 문자로 나눈 후 정렬해서 비교
                if (string.Concat(word.OrderBy(c => c)) == _concatSpell)
                {
                    return 1;  // 일치하는 단어가 있으면 1 반환
                }
            }
            return 2;  // 일치하는 단어가 없으면 2 반환
        }
    }
    class 외계어_사전
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _spell01 = { "p", "o", "s" };
            string[] _spell02 = { "z", "d", "x" };
            string[] _spell03 = { "s", "o", "m", "d" };

            string[] _dic01 = { "sod", "eocd", "qixm", "adio", "soo" };
            string[] _dic02 = { "def", "dww", "dzx", "loveaw" };
            string[] _dic03 = { "moos", "dzx", "smm", "sunmmo", "som" };

            Console.WriteLine(_solution.solution(_spell01, _dic01));        //  2
            Console.WriteLine(_solution.solution(_spell02, _dic02));        //  1
            Console.WriteLine(_solution.solution(_spell03, _dic03));        //  2
        }
    }
    */
}