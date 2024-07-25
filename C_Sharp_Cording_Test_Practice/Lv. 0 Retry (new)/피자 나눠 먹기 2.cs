using System;

/* Retry : 유클리드 호제법
 * 머쓱이네 피자가게는 피자를 여섯 조각으로 잘라 줍니다. 
 * 
 * 피자를 나눠먹을 사람의 수 n이 매개변수로 주어질 때, 
 * n명이 주문한 피자를 남기지 않고 모두 같은 수의 피자 조각을 먹어야 한다면 
 * 최소 몇 판을 시켜야 하는지를 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        // 최대공약수(GCD)를 구하는 함수
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // 최소공배수(LCM)를 구하는 함수
        private int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        //  유클리드 호제법
        public int solution(int n)
        {
            int lcm = LCM(n, 6);
            return lcm / 6;
        }
    }
    class 피자_나눠_먹기_2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(6));       //  1
            Console.WriteLine(_solution.solution(10));      //  5
            Console.WriteLine(_solution.solution(4));       //  2
        }
    }
    */
}
