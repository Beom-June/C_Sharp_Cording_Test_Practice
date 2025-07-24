using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 수를 입력받아 두 수의 최대공약수와 최소공배수를 반환하는 함수, solution을 완성해 보세요. 
 * 배열의 맨 앞에 최대공약수, 그다음 최소공배수를 넣어 반환하면 됩니다. 
 * 
 * 예를 들어 두 수 3, 12의 최대공약수는 3, 최소공배수는 12이므로 
 * solution(3, 12)는 [3, 12]를 반환해야 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int n, int m)
        {
            int[] answer = new int[2];

            int _min, _max;

            //최대공약수 -> 유클리드 호제법 gcd(n, m) = gcd(m, n%m)
            _min = gcd(n, m);
            //최소공배수 -> 두수의 곱 / 최대 공약수
            _max = (n * m) / _min;

            answer[0] = _min;
            answer[1] = _max;

            return answer;
        }
        public int gcd(int n, int m)
        {
            //두 수 n, m 이 있을 때 어느 한 수가 0이 될 때 까지
            //gcd(m, n%m) 의 재귀함수 반복
            if (m == 0) 
                return n;
            else 
                return gcd(m, n % m);
        }
    }
    class 최대공약수와_최소공배수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _n1 = 3, _n2 = 2;
            int _m1 = 12, _m2 = 5;

            foreach (var _result in _solution.solution(_n1, _m1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
            
            foreach (var _result in _solution.solution(_n2, _m2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
