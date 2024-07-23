using System;
using System.Collections.Generic;
using System.Linq;

/* Retry
 * 정수가 담긴 배열 numbers와 문자열 direction가 매개변수로 주어집니다. 
 * 
 * 배열 numbers의 원소를 direction방향으로 한 칸씩 회전시킨 배열을 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] numbers, string direction)
        {
            List<int> answer = new List<int>(numbers);
            if (direction == "right")
            {
                int last = answer.Last(); // 마지막 요소 저장
                answer.RemoveAt(answer.Count - 1); // 마지막 요소 삭제
                answer.Insert(0, last); // 저장한 마지막 요소를 첫 번째 위치에 삽입
            }
            else if (direction == "left")
            {
                int first = answer.First(); // 첫 번째 요소 저장
                answer.RemoveAt(0); // 첫 번째 요소 삭제
                answer.Add(first); // 저장한 첫 번째 요소를 마지막 위치에 추가
            }
            return answer.ToArray();
        }
    }
    class 배열_회전_시키기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers01 = { 1, 2, 3 };
            int[] _numbers02 = { 4, 455, 6, 4, -1, 45, 6 };

            string _dir01 = "right";
            string _dir02 = "left";

            foreach (var i in _solution.solution(_numbers01, _dir01))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (var i in _solution.solution(_numbers02, _dir02))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}