using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 myString과 pat이 주어집니다. 
 * myString에서 pat이 등장하는 횟수를 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string myString, string pat)
        {
            int answer = 0;

            for (int i = 0; i <= myString.Length - pat.Length; i++)
            {
                bool _isMatched = true;

                for (int j = 0; j < pat.Length; j++)
                {
                    if (myString[i + j] != pat[j])
                    {
                        _isMatched = false;
                        break;
                    }
                }

                if (_isMatched)
                    answer++;
            }
            return answer;
        }
    }
    class 문자열이_몇_번_등장하는지_세기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString1 = "banana";
            string _myString2 = "aaaa";

            string _pat1 = "ana";
            string _pat2 = "aa";

            Console.WriteLine(_solution.solution(_myString1, _pat1));
            Console.WriteLine(_solution.solution(_myString2, _pat2));
        }
    }
*/    
}
