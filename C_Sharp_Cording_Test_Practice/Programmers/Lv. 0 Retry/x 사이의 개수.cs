using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 myString이 주어집니다.
 * myString을 문자 "x"를 기준으로 나눴을 때 나눠진 문자열 
 * 각각의 길이를 순서대로 저장한 배열을 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(string myString)
        {
            List<int> _answer = new List<int>();
            string _delimiter = "x";

            string[] _parts = myString.Split(new string[] { _delimiter }, StringSplitOptions.None);

            foreach (string _result in _parts)
            {
                _answer.Add(_result.Length);
            }

            return _answer.ToArray();
        }
    }
    class x_사이의_개수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString1 = "oxooxoxxox";
            string _myString2 = "xabcxdefxghi";

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
