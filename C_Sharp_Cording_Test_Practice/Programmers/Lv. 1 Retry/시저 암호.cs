using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 어떤 문장의 각 알파벳을 일정한 거리만큼 밀어서 
 * 다른 알파벳으로 바꾸는 암호화 방식을 시저 암호라고 합니다. 
 * 
 * 예를 들어 "AB"는 1만큼 밀면 "BC"가 되고, 3만큼 밀면 "DE"가 됩니다. 
 * "z"는 1만큼 밀면 "a"가 됩니다. 
 * 
 * 문자열 s와 거리 n을 입력받아 s를 n만큼 민 암호문을 만드는 함수, 
 * solution을 완성해 보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string s, int n)
        {
            string answer = "";
            foreach (char _char in s)
            {
                if (_char != ' ')
                {
                    int _tmp = 0;

                    //ASCII 코드
                    //A=65, Z=90, a=97, z=122

                    //대문자
                    if ((int)_char < 91)
                    {
                        _tmp = (int)_char + n;
                        if (_tmp > 90)
                        {
                            _tmp = 64 + (_tmp - 90);
                        }
                    }
                    //소문자
                    else
                    {
                        _tmp = (int)_char + n;
                        if (_tmp > 122)
                        {
                            _tmp = 96 + (_tmp - 122);
                        }
                    }
                    answer += Convert.ToChar(_tmp);
                }
                else
                    answer += ' ';
            }
            return answer;
        }
    }
    class 시저_암호
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s01 = "AB";
            string _s02 = "z";
            string _s03 = "a B z";

            int _n1 = 1, _n2 = 1, _n3 = 4;

            Console.WriteLine(_solution.solution(_s01, _n1));       //  BC
            Console.WriteLine(_solution.solution(_s02, _n2));       //  a
            Console.WriteLine(_solution.solution(_s03, _n3));       //  e F d
        }
    }
    */
}
