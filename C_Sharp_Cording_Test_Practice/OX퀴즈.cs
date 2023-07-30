using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 덧셈, 뺄셈 수식들이 'X [연산자] Y = Z' 형태로 들어있는 
 * 문자열 배열 quiz가 매개변수로 주어집니다. 
 * 수식이 옳다면 "O"를 틀리다면 "X"를 순서대로 담은 배열을 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] quiz)
        {
            string[] answer = new string[quiz.Length];
            for (int i = 0; i < quiz.Length; i++)
            {
                answer[i] = CheckCorrectOperation(quiz[i]) ? "O" : "X";
            }

            return answer;
        }

        // 올바른 수식인지 판단하는 함수.
        public bool CheckCorrectOperation(string str)
        {
            // 공백을 기준을 str을 자름.
            string[] _elements = str.Split(" "); ;

            // elements[0] -> 연산자의 왼쪽 값
            int _leftVal = int.Parse(_elements[0]);

            // elements[2] -> 연산자의 오른쪽 값
            int _rightVal = int.Parse(_elements[2]);

            // elements[4] -> str의 결과 값
            int _resultVal = int.Parse(_elements[4]);

            // str의 결과값과 실제 leftVal, rightVal값을 실제 연산하여 비교 진행
            return _resultVal == ((_elements[1] == "+") ? _leftVal + _rightVal : _leftVal - _rightVal);
        }
    }
    class OX퀴즈
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _quiz1 = { "3 - 4 = -3", "5 + 6 = 11" };
            string[] _quiz2 = { "19 - 6 = 13", "5 + 66 = 71", "5 - 15 = 63", "3 - 1 = 2" };

            foreach (var _quiz in _solution.solution(_quiz1))
            {
                Console.Write(_quiz + " ");
            }
            Console.WriteLine();

            foreach (var _quiz in _solution.solution(_quiz2))
            {
                Console.Write(_quiz + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
