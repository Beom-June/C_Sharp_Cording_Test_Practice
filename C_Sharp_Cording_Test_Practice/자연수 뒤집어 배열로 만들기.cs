using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴해주세요. 
 * 예를들어 n이 12345이면 [5,4,3,2,1]을 리턴합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(long n)
        {
            char[] _answer = n.ToString().ToCharArray();
            Array.Reverse(_answer);

            int[] _result = new int[_answer.Length];
            for (int i = 0; i < _answer.Length; i++)
            {
                _result[i] = int.Parse(_answer[i].ToString());
            }

            return _result;
        }
    }
    class 자연수_뒤집어_배열로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n = 12345;

            foreach (var _result in _solution.solution(_n))
            {
                Console.Write(_result + " ");
            }
        }
    }
    */
}
