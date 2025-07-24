using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 정수가 담긴 배열 numbers와 문자열 direction가 매개변수로 주어집니다. 
 * 배열 numbers의 원소를 direction방향으로 한 칸씩 회전시킨 
 * 배열을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] numbers, string direction)
        {
            int[] answer = new int[numbers.Length];

            if (direction == "right")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    int _Idx = (i + 1) % numbers.Length;
                    answer[_Idx] = numbers[i];
                }
            }
            else if (direction == "left")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    int _Idx = (i - 1 + numbers.Length) % numbers.Length;
                    answer[_Idx] = numbers[i];
                }
            }
            return answer;
        }
    }
    class 배열_회전_시키기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers1 = { 1, 2, 3 };
            int[] _numbers2 = { 4, 455, 6, 4, -1, 45, 6 };

            string _direction1 = "right";
            string _direction2 = "left";

            int[] result1 = _solution.solution(_numbers1, _direction1);
            Console.WriteLine(string.Join(", ", result1)); // 출력: 3, 1, 2

            int[] result2 = _solution.solution(_numbers2, _direction2);
            Console.WriteLine(string.Join(", ", result2)); // 출력: 455, 6, 4, -1, 45, 6, 4
        }
    }
    */
}