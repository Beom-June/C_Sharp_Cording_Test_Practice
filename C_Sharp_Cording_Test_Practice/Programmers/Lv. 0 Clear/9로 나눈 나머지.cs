using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 음이 아닌 정수를 9로 나눈 나머지는 
 * 그 정수의 각 자리 숫자의 합을 9로 나눈 나머지와 같은 것이 알려져 있습니다.
 * 
 * 이 사실을 이용하여 음이 아닌 정수가 문자열 number로 주어질 때, 
 * 이 정수를 9로 나눈 나머지를 return 하는 solution 함수를 작성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string number)
        {
            int answer = 0;
            int _sum = 0;

            foreach (var _digit in number)
            {
                _sum += int.Parse(_digit.ToString());
            }
            answer = _sum % 9;
            return answer;
        }
    }
    class _9로_나눈_나머지
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _number1 = "123";
            string _number2 = "78720646226947352489";

            Console.WriteLine(_solution.solution(_number1));
            Console.WriteLine(_solution.solution(_number2));
        }
    }
    */
}
