using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 소수점 아래 숫자가 계속되지 않고 유한개인 소수를 유한소수라고 합니다. 
 * 분수를 소수로 고칠 때 유한소수로 나타낼 수 있는 분수인지 판별하려고 합니다. 
 * 유한소수가 되기 위한 분수의 조건은 다음과 같습니다. 
 * 기약분수로 나타내었을 때, 분모의 소인수가 2와 5만 존재해야 합니다.
 * 두 정수 a와 b가 매개변수로 주어질 때, a/b가 유한소수이면 1을, 무한소수라면 2를 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        // a : 분자, b : 분모
        public int solution(int a, int b)
        {
            int _answer = 1;
            // 분모의 소인수가 2와 5로만 이루어져 있는지 확인
            while (b % 2 == 0)
            {
                b /= 2;
            }
            while (b % 5 == 0)
            {
                b /= 5;
            }

            if (a % b != 0)
            {
                _answer = 2;
            }

            return _answer;
        }
    }
    class 유한소수_판별하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _a1 = 7;
            int _a2 = 11;
            int _a3 = 12;

            int _b1 = 20;
            int _b2 = 22;
            int _b3 = 21;

            Console.WriteLine(_solution.solution(_a1, _b1));
            Console.WriteLine(_solution.solution(_a2, _b2));
            Console.WriteLine(_solution.solution(_a3, _b3));
        }
    }
    */
}
