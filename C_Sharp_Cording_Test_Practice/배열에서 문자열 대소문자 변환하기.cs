using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 배열 strArr가 주어집니다. 
 * 모든 원소가 알파벳으로만 이루어져 있을 때, 
 * 배열에서 홀수번째 인덱스의 문자열은 모든 문자를 대문자로, 
 * 짝수번째 인덱스의 문자열은 모든 문자를 소문자로 바꿔서 반환하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] strArr)
        {
            List<string> _answer = new List<string>();

            for (int i = 0; i < strArr.Length; i++)
            {
                if (i % 2 == 0)  // 짝수 인덱스 (0부터 시작하므로)
                {
                    _answer.Add(strArr[i].ToLower());  // 모든 문자를 소문자로 변환하여 추가
                }
                else  // 홀수 인덱스
                {
                    _answer.Add(strArr[i].ToUpper());  // 모든 문자를 대문자로 변환하여 추가
                }
            }
            return _answer.ToArray();
        }
    }
    class 배열에서_문자열_대소문자_변환하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _strArr1 = { "AAA", "BBB", "CCC", "DDD" };
            string[] _strArr2 = { "aBc", "AbC" };

            Console.WriteLine(string.Join(" ", _strArr1));
            Console.WriteLine(string.Join(" ", _strArr2));
        }
    }
    */
}
