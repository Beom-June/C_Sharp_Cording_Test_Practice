using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 배열 strArr가 주어집니다. 
 * 배열 내의 문자열 중 "ad"라는 부분 문자열을 포함하고 있는 
 * 모든 문자열을 제거하고 남은 문자열을 순서를 유지하여 배열로 
 * return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] strArr)
        {
            List<string> _answer = new List<string>();
            string _remove = "ad";

            foreach (string str in strArr)
            {
                if (!str.Contains(_remove))
                {
                    _answer.Add(str);
                }
            }
            return _answer.ToArray();
        }
    }
    class ad_제거하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _strArr1 = { "and", "notad", "abcd" };
            string[] _strArr2 = { "there", "are", "no", "a", "ds" };

            Console.WriteLine(string.Join(", ", _solution.solution(_strArr1)));
            Console.WriteLine(string.Join(", ", _solution.solution(_strArr2)));
        }
    }
    */
}
