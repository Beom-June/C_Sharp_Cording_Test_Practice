using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습 및 개선
 * 1부터 6까지 숫자가 적힌 주사위가 네 개 있습니다. 네 주사위를 굴렸을 때 나온 숫자에 따라 다음과 같은 점수를 얻습니다.
 * 
 * 네 주사위에서 나온 숫자가 모두 p로 같다면 1111 × p점을 얻습니다.
 * 세 주사위에서 나온 숫자가 p로 같고 나머지 다른 주사위에서 나온 숫자가 q(p ≠ q)라면 (10 × p + q)2 점을 얻습니다.
 * 주사위가 두 개씩 같은 값이 나오고, 나온 숫자를 각각 p, q(p ≠ q)라고 한다면 (p + q) × |p - q|점을 얻습니다.
 * 어느 두 주사위에서 나온 숫자가 p로 같고 나머지 두 주사위에서 나온 숫자가 각각 p와 다른 q, r(q ≠ r)이라면 q × r점을 얻습니다.
 * 네 주사위에 적힌 숫자가 모두 다르다면 나온 숫자 중 가장 작은 숫자 만큼의 점수를 얻습니다.
 * 
 * 네 주사위를 굴렸을 때 나온 숫자가 정수 매개변수 a, b, c, d로 주어질 때, 
 * 얻는 점수를 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int a, int b, int c, int d)
        {
            int[] dice = { a, b, c, d };
            Array.Sort(dice);

            // case 1 : 네 주사위에서 나온 숫자가 모두 p로 같다면
            if (dice[0] == dice[3])
            {
                return dice[0] * 1111;
            }

            // case 2 : 세 주사위에서 나온 숫자가 p로 같고 나머지 다른 주사위에서 나온 숫자가 q(p ≠ q)
            else if (dice[1] == dice[3])
            {
                return (10 * dice[3] + dice[0]) * (10 * dice[3] + dice[0]);
            }

            // case 3 : 주사위가 두 개씩 같은 값이 나오고, 나온 숫자를 각각 p, q(p ≠ q)
            else if (dice[0] == dice[1] && dice[2] == dice[3])
            {
                return (dice[0] + dice[2]) * Math.Abs(dice[0] - dice[2]);
            }

            // case 4 : 어느 두 주사위에서 나온 숫자가 p로 같고 나머지 두 주사위에서 나온 숫자가 각각 p와 다른 q, r(q ≠ r)
            else if (dice[0] == dice[1] && dice[1] != dice[2] && dice[3] != dice[1])
            {
                return dice[2] * dice[3];
            }

            // case 5 : 네 주사위에 적힌 숫자가 모두 다르다면 나온 숫자 중 가장 작은 숫자 만큼
            else
            {
                return dice[0];
            }
        }
    }
    class 주사위_게임_3
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _a1 = 2, _a2 = 4, _a3 = 6, _a4 = 2, _a5 = 6;
            int _b1 = 2, _b2 = 1, _b3 = 3, _b4 = 5, _b5 = 4;
            int _c1 = 2, _c2 = 4, _c3 = 3, _c4 = 2, _c5 = 2;
            int _d1 = 2, _d2 = 4, _d3 = 6, _d4 = 6, _d5 = 5;

            Console.WriteLine(_solution.solution(_a1, _b1, _c1, _d1));
            Console.WriteLine(_solution.solution(_a2, _b2, _c2, _d2));
            Console.WriteLine(_solution.solution(_a3, _b3, _c3, _d3));
            Console.WriteLine(_solution.solution(_a4, _b4, _c4, _d4));
            Console.WriteLine(_solution.solution(_a5, _b5, _c5, _d5));
        }
    }
    */
}
