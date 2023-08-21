using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 리스트 str_list에는 "u", "d", "l", "r" 네 개의 문자열이 여러 개 저장되어 있습니다. 
 * str_list에서 "l"과 "r" 중 먼저 나오는 문자열이 "l"이라면 
 * 해당 문자열을 기준으로 왼쪽에 있는 문자열들을 순서대로 담은 리스트를, 
 * 먼저 나오는 문자열이 "r"이라면 해당 문자열을 기준으로 오른쪽에 있는 문자열들을 
 * 순서대로 담은 리스트를 return하도록 solution 함수를 완성해주세요. 
 * "l"이나 "r"이 없다면 빈 리스트를 return합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] str_list)
        {
            List<string> _answer = new List<string>();

            int _idxL = Array.IndexOf(str_list, "l");
            int _idxR = Array.IndexOf(str_list, "r");

            if (_idxL != -1 && (_idxR == -1 || _idxL < _idxR))
            {
                _answer.AddRange(str_list.Take(_idxL));
            }
            else if (_idxR != -1 && (_idxL == -1 || _idxR < _idxL))
            {
                _answer.AddRange(str_list.Skip(_idxR + 1));
            }
            return _answer.ToArray();
        }
    }
    class 왼쪽_오른쪽
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _str_list1 = { "u", "u", "l", "r" };
            string[] _str_list2 = { "l" };

            string[] result1 = _solution.solution(_str_list1);
            string[] result2 = _solution.solution(_str_list2);

            Console.WriteLine(string.Join(" ", result1)); 
            Console.WriteLine(string.Join(" ", result2));
        }
    }
    */
}
