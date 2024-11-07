using System;

/* Retry
 * 덧셈, 뺄셈 수식들이 'X [연산자] Y = Z' 형태로 들어있는 문자열 배열 quiz가 매개변수로 주어집니다. 
 * 수식이 옳다면 "O"를 틀리다면 "X"를 순서대로 담은 배열을 return하도록 solution 함수를 완성해주세요.
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
                string[] _elements = quiz[i].Split(" ");

                int _leftValue = int.Parse(_elements[0]);
                string _operation = _elements[1];
                int _rightValue = int.Parse(_elements[2]);
                int _resultValue = int.Parse(_elements[4]);

                int _result;
                if (_operation == "+")
                {
                    _result = _leftValue + _rightValue;
                }
                else // operation == "-"
                {
                    _result = _leftValue - _rightValue;
                }

                //  마지막 비교해서 맞는지
                answer[i] = (_result == _resultValue) ? "O" : "X";
            }
            return answer;
        }
    }
    class OX퀴즈
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _quiz01 = { "3 - 4 = -3", "5 + 6 = 11" };
            string[] _quiz02 = { "19 - 6 = 13", "5 + 66 = 71", "5 - 15 = 63", "3 - 1 = 2" };

            //  "X", "O"
            foreach (var s in _solution.solution(_quiz01))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            //  "O", "O", "X", "O"
            foreach (var s in _solution.solution(_quiz02))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
