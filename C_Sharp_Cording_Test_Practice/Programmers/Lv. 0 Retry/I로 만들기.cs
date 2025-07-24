using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 알파벳 소문자로 이루어진 문자열 myString이 주어집니다. 
 * 알파벳 순서에서 "l"보다 앞서는 모든 문자를 "l"로 바꾼 문자열을 
 * return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string myString)
        {
            char[] _array = myString.ToCharArray();

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < 'l')
                {
                    _array[i] = 'l';
                }
            }

            return new string(_array);
        }
    }
    class I로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString1 = "abcdevwxyz";
            string _myString2 = "jjnnllkkmm";

            Console.WriteLine(_solution.solution(_myString1)); // "llllllllll"
            Console.WriteLine(_solution.solution(_myString2)); // "llllllkkmm"
        }
    }
    */
}
