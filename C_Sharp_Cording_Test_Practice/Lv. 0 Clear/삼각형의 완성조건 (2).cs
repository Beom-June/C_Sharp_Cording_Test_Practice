using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 선분 세 개로 삼각형을 만들기 위해서는 다음과 같은 조건을 만족해야 합니다.
 * 가장 긴 변의 길이는 다른 두 변의 길이의 합보다 작아야 합니다.
 * 삼각형의 두 변의 길이가 담긴 배열 sides이 매개변수로 주어집니다. 
 * 나머지 한 변이 될 수 있는 정수의 개수를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] sides)
        {
            int a = sides.Max() - sides.Min();
            int b = sides.Max() + sides.Min();

    //삼각형의 변의 길이는 자연수이기 때문에 가장 큰 변의 길이보다 1 작은 길이까지의 정수만 사용 가능하기 때문
            int answer = b - a - 1;

            return answer;
        }
    }
    class 삼각형의_완성조건__2_
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _sides1 = { 1, 2 };
            int[] _sides2 = { 3, 6 };
            int[] _sides3 = { 11, 7 };

            Console.WriteLine(_solution.solution(_sides1));
            Console.WriteLine(_solution.solution(_sides2));
            Console.WriteLine(_solution.solution(_sides3));
        }
    }
    */
}
