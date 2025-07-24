using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 binomial이 매개변수로 주어집니다. 
 * binomial은 "a op b" 형태의 이항식이고 a와 b는 음이 아닌 정수, 
 * op는 '+', '-', '*' 중 하나입니다. 주어진 식을 계산한 정수를 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string binomial)
        {
            int answer = 0;
            // 공백을 기준으로 문자열을 나눔
            string[] _parts = binomial.Split(' ');

            int _operand1 = int.Parse(_parts[0]); // 첫 번째 피연산자
            char _operator = _parts[1][0]; // 연산자
            int _operand2 = int.Parse(_parts[2]); // 두 번째 피연산자

            // 연산을 수행하여 결과 계산
            switch (_operator)
            {
                case '+':
                    answer = _operand1 + _operand2;
                    break;
                case '-':
                    answer = _operand1 - _operand2;
                    break;
                case '*':
                    answer = _operand1 * _operand2;
                    break;
                default:
                    break;
            }
            return answer;
        }
    }
    class 간단한_식_계산하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _binomial1 = "43 + 12";
            string _binomial2 = "0 - 7777";
            string _binomial3 = "40000 * 40000";

            Console.WriteLine(_solution.solution(_binomial1));
            Console.WriteLine(_solution.solution(_binomial2));
            Console.WriteLine(_solution.solution(_binomial3));
        }
    }
    */
}
