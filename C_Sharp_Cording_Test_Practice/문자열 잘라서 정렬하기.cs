using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 myString이 주어집니다. 
 * "x"를 기준으로 해당 문자열을 잘라내 배열을 만든 후 
 * 사전순으로 정렬한 배열을 return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, 빈 문자열은 반환할 배열에 넣지 않습니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string myString)
        {
            List<string> _answer = new List<string>();
            string _x = "x";

            string[] _parts = myString.Split(new string[] { _x }, StringSplitOptions.None);

            foreach (string _result in _parts)
            {
                if (!string.IsNullOrEmpty(_result)) // 빈 문자열은 제외
                {
                    _answer.Add(_result);
                }
            }

            _answer.Sort(); // 사전순으로 정렬

            return _answer.ToArray();
        }
    }
    class 문자열_잘라서_정렬하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString1 = "axbxcxdx";
            string _myString2 = "dxccxbbbxaaaa";

            foreach (var _result in _solution.solution(_myString1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_myString2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
