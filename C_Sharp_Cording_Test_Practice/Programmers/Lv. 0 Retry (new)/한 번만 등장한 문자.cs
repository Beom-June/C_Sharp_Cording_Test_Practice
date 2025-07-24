using System;
using System.Linq;

/* Retry
 * 문자열 s가 매개변수로 주어집니다. 
 * s에서 한 번만 등장하는 문자를 사전 순으로 정렬한 문자열을 
 * return 하도록 solution 함수를 완성해보세요. 
 * 한 번만 등장하는 문자가 없을 경우 빈 문자열을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string s)
        {
            //string answer = "";

            //char[] _arrChar = s.ToCharArray();
            //Array.Sort(_arrChar);
            //string _sortChar = new string(_arrChar);

            //answer = _sortChar;

            //  Where : 제네릭 형식, 메서드, 대리자 또는 로컬 함수의 형식 매개 변수에 대한 인수로 사용되는 형식에 대한 제약 조건을 지정
            //  Concat : 배열 연결, 문자열 연결
            //  OrderBy : 오름차순 정렬
            string answer = string.Concat(s.Where(x => s.Count(o => o == x) == 1).OrderBy(x => x));
            return answer;
        }
    }
    class 한_번만_등장한_문자
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s01 = "abcabcadc";
            string _s02 = "abdc";
            string _s03 = "hello";

            Console.WriteLine(_solution.solution(_s01));
            Console.WriteLine(_solution.solution(_s02));
            Console.WriteLine(_solution.solution(_s03));
        }
    }
    */
}
