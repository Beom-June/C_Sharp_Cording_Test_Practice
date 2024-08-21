using System;
using System.Linq;

/* 선분 세 개로 삼각형을 만들기 위해서는 다음과 같은 조건을 만족해야 합니다.
 * 
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
            int _x = sides.Max() - sides.Min();     //  가장 큰 값과 가장 작은 값의 차이
            int _y = sides.Max() + sides.Min();     //  가장 큰 값과 가장 작은 값의 합
            int answer = _y - _x - 1;               //  나머지 변에 가능한 길이 범위 계산
            return answer;
        }
    }
    class 삼각형의_완성_조건_2
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _sides01 = { 1, 2 };
            int[] _sides02 = { 3, 6 };
            int[] _sides03 = { 11, 7 };

            Console.WriteLine(_solution.solution(_sides01));
            Console.WriteLine(_solution.solution(_sides02));
            Console.WriteLine(_solution.solution(_sides03));
        }
    }
    */
}