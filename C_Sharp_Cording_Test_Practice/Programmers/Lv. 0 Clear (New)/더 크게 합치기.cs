using System;

/* 연산 ⊕는 두 정수에 대한 연산으로 두 정수를 붙여서 쓴 값을 반환합니다. 예를 들면 다음과 같습니다.
 * 
 * 12 ⊕ 3 = 123
 * 3 ⊕ 12 = 312
 * 양의 정수 a와 b가 주어졌을 때, a ⊕ b와 b ⊕ a 중 더 큰 값을 return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, a ⊕ b와 b ⊕ a가 같다면 a ⊕ b를 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int a, int b)
        {
            int answer = 0;
            string _hap01 = a.ToString() + b.ToString();
            string _hap02 = b.ToString() + a.ToString();

            int _parseHap01 = int.Parse(_hap01);
            int _parseHap02 = int.Parse(_hap02);

            if (_parseHap01 >= _parseHap02)
            {
                return answer = _parseHap01;
            }
            else
            {
                return answer = _parseHap02;
            }
        }
    }
    class 더_크게_합치기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(9, 91));
            Console.WriteLine(_solution.solution(8, 89));
        }
    }
    */
}