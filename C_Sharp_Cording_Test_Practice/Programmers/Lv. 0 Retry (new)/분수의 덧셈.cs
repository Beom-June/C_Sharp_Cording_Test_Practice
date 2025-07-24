using System;

/* Retry
 * 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1, 
 * 두 번째 분수의 분자와 분모를 뜻하는 numer2, denom2가 매개변수로 주어집니다. 
 * 
 * 두 분수를 더한 값을 기약 분수로 나타냈을 때 분자와 분모를 순서대로 담은 배열을 
 * return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int numer1, int denom1, int numer2, int denom2)
        {
            // 분모의 최소공배수 계산
            int _lcm = LCM(denom1, denom2);

            // 분자 계산
            int _numerSum = numer1 * (_lcm / denom1) + numer2 * (_lcm / denom2);

            // 기약분수로 만들기
            int _gcd = GCD(_numerSum, _lcm);
            _numerSum /= _gcd;
            _lcm /= _gcd;

            return new int[] { _numerSum, _lcm };
        }

        //  최대 공약수 계산 함수
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int _temp = b;
                b = a % b;
                a = _temp;
            }
            return a;
        }

        //  최소 공배수 계산 함수
        private int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }

    class 분수의_덧셈
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            //  5, 4
            foreach (var i in _solution.solution(1, 2, 3, 4))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //  29, 6
            foreach (var i in _solution.solution(9, 2, 1, 3))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}