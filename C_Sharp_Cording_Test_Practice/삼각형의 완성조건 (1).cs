using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 선분 세 개로 삼각형을 만들기 위해서는 다음과 같은 조건을 만족해야 합니다.
 * 가장 긴 변의 길이는 다른 두 변의 길이의 합보다 작아야 합니다.
 * 삼각형의 세 변의 길이가 담긴 배열 sides이 매개변수로 주어집니다. 
 * 세 변으로 삼각형을 만들 수 있다면 1, 만들 수 없다면 2를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] sides)
        {
            int answer = 0;

            Array.Sort(sides);

            //int _max = sides.Max();
            //int _min = sides.Min();
            //int _middle = (_max + _min) / 2;
            //// 가능 하면
            //if(_max <= _min + _middle)
            //{
            //    answer = 2;
            //}
            //else
            //{
            //    answer = 1;
            //}
            int _max = sides[2];
            int _sum = sides[0] + sides[1];

            if (_max < _sum)
            {
                answer = 1; // 삼각형을 만들 수 있음
            }
            else
            {
                answer = 2; // 삼각형을 만들 수 없음
            }

            return answer;
        }
    }
    class 삼각형의_완성조건__1_
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _sides1 = { 1, 2, 3 };
            int[] _sides2 = { 3, 6, 2 };
            int[] _sides3 = { 199, 72, 222 };

            Console.WriteLine(_solution.solution(_sides1));
            Console.WriteLine(_solution.solution(_sides2));
            Console.WriteLine(_solution.solution(_sides3));
        }
    }
    */
}
