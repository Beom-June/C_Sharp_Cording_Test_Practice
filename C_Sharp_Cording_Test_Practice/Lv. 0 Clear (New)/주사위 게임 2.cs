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
            int sum = a + b + c;
            int sumOfSquares = a * a + b * b + c * c;
            int sumOfCubes = a * a * a + b * b * b + c * c * c;

            if (a == b && b == c)
            {
                // 세 숫자가 모두 같다면
                return sum * sumOfSquares * sumOfCubes;
            }
            else if (a == b || b == c || c == a)
            {
                // 두 숫자는 같고 나머지 숫자는 다른 경우
                return sum * sumOfSquares;
            }
            else
            {
                // 세 숫자가 모두 다른 경우
                return sum;
            }
        }
    }
    class 주사위_게임_2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();
            Console.WriteLine(_solution.solution(2, 6, 1));
            Console.WriteLine(_solution.solution(5, 3, 3));
            Console.WriteLine(_solution.solution(4, 4, 4));
        }
    }
    */
}
