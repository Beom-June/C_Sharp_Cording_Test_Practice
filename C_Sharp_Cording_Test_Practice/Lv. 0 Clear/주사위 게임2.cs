using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1부터 6까지 숫자가 적힌 주사위가 세 개 있습니다. 
 * 세 주사위를 굴렸을 때 나온 숫자를 각각 a, b, c라고 했을 때 얻는 점수는 다음과 같습니다.
 * 
 * 세 숫자가 모두 다르다면 a + b + c 점을 얻습니다.
 * 세 숫자 중 어느 두 숫자는 같고 나머지 다른 숫자는 다르다면 (a + b + c) × (a2 + b2 + c2 )점을 얻습니다.
 * 세 숫자가 모두 같다면 (a + b + c) × (a2 + b2 + c2 ) × (a3 + b3 + c3 )점을 얻습니다.
 * 세 정수 a, b, c가 매개변수로 주어질 때, 얻는 점수를 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int a, int b, int c)
        {
            int answer = 0;
            int _sum = a + b + c;
            int _squareSum = a * a + b * b + c * c;
            int _cubricSum = a * a * a + b * b * b + c * c * c;

            // 모두 같다
            if (a == b && b == c)
            {
                answer = _sum * _squareSum * _cubricSum;
            }
            // 두개만 같다
            else if (a == b || b == c || c == a)
            {
                answer = _sum * _squareSum;
            }
            // 나머지
            else
            {
                answer = _sum;
            }
            return answer;
        }
    }
    class 주사위_게임2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _a1 = 2, _a2 = 5, _a3 = 4;
            int _b1 = 6, _b2 = 3, _b3 = 4;
            int _c1 = 1, _c2 = 3, _c3 = 4;

            Console.WriteLine(_solution.solution(_a1, _b1, _c1));
            Console.WriteLine(_solution.solution(_a2, _b2, _c2));
            Console.WriteLine(_solution.solution(_a3, _b3, _c3));
        }
    }
    */
}
