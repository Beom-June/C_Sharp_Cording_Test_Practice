using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 단어가 공백 한 개 이상으로 구분되어 있는 문자열 
 * my_string이 매개변수로 주어질 때, my_string에 나온 단어를 
 * 앞에서부터 순서대로 담은 문자열 배열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string my_string)
        {
            List<string> _answer = new List<string>();
            // 문자열을 공백으로 분리
            string[] _parts = my_string.Split(' ');

            // 공백이 아닌 부분 문자열들을 _answer에 추가
            foreach (string _result in _parts)
            {
                if (!string.IsNullOrWhiteSpace(_result))
                {
                    _answer.Add(_result);
                }
            }
            return _answer.ToArray();
        }
    }
    class 공백으로_구분하기_2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = " i    love  you";
            string _my_string2 = "    programmers  ";

            Console.WriteLine(string.Join(" ", _my_string1));
            Console.WriteLine(string.Join(" ", _my_string2));
        }
    }
    */
}
