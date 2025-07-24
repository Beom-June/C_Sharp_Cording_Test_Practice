using System;

/* 문자열 binomial이 매개변수로 주어집니다. 
 * 
 * binomial은 "a op b" 형태의 이항식이고 a와 b는 
 * 음이 아닌 정수, op는 '+', '-', '*' 중 하나입니다. 
 * 
 * 주어진 식을 계산한 정수를 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string binomial)
        {
            // 공백을 기준으로 문자열을 분리
            string[] _parts = binomial.Split(' ');

            // 첫 번째 숫자
            int _a = int.Parse(_parts[0]);
            // 연산자
            string _op = _parts[1];
            // 두 번째 숫자
            int _b = int.Parse(_parts[2]);

            int answer = 0;

            // 연산자에 따라 계산 수행
            switch (_op)
            {
                case "+":
                    answer = _a + _b;
                    break;
                case "-":
                    answer = _a - _b;
                    break;
                case "*":
                    answer = _a * _b;
                    break;
                default:
                    throw new InvalidOperationException("Error");
            }
            return answer;
        }
    }
    class 간단한_식_계산하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _bin01 = "43 + 12";
            string _bin02 = "0 - 7777";
            string _bin03 = "40000 * 40000";

            Console.WriteLine(_solution.solution(_bin01));
            Console.WriteLine(_solution.solution(_bin02));
            Console.WriteLine(_solution.solution(_bin03));
        }
    }
    */
}