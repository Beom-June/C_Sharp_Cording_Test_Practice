using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 연산 ⊕는 두 정수에 대한 연산으로 두 정수를 붙여서 쓴 값을 반환합니다. 예를 들면 다음과 같습니다.
 * 
 * 12 ⊕ 3 = 123
 * 3 ⊕ 12 = 312
 * 
 * 양의 정수 a와 b가 주어졌을 때, a ⊕ b와 2 * a * b 중 더 큰 값을 return하는 solution 함수를 완성해 주세요.
 * 
 * 단, a ⊕ b와 2 * a * b가 같으면 a ⊕ b를 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int a, int b)
        {
            int answer = 0;
            string _result = a.ToString() + b.ToString();
            int _2ab = 2 * a * b;

            if(int.Parse(_result) > _2ab)
            {
                return answer = int.Parse(_result);
            }
            else if (int.Parse(_result) < _2ab)
            {
                return answer = _2ab;
            }
            else
            {
                return answer = int.Parse(_result);
            }
        }
    }
    class 두_수의_연산값_비교하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(2, 91));   //  364
            Console.WriteLine(_solution.solution(91, 2));   //  912
        }
    }
    */
}