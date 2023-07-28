using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 my_string과 정수 num1, num2가 매개변수로 주어질 때, 
 * my_string에서 인덱스 num1과 인덱스 num2에 해당하는 문자를 바꾼 문자열을 
 * return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, int num1, int num2)
        {
            string answer = "";
            char[] _array = my_string.ToCharArray();
            char _ch;

            _ch = _array[num1];
            _array[num1] = _array[num2];
            _array[num2] = _ch;

            // 연결
            answer = string.Concat(_array);
            return answer;
        }
    }
    class 인덱스_바꾸기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "hello";
            string _my_string2 = "I love you";

            int _num1_1 = 1;
            int _num1_2 = 3;

            int _num2_1 = 2;
            int _num2_2 = 6;

            Console.WriteLine(_solution.solution(_my_string1, _num1_1, _num2_1));
            Console.WriteLine(_solution.solution(_my_string2, _num1_2, _num2_2));
        }
    }
    */
}
