using System;

/* 연속된 세 개의 정수를 더해 12가 되는 경우는 3, 4, 5입니다. 
 * 두 정수 num과 total이 주어집니다. 
 * 
 * 연속된 수 num개를 더한 값이 total이 될 때, 정수 배열을 오름차순으로 담아 
 * return하도록 solution함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int num, int total)
        {
            int[] answer = new int[num];

            //  total / num은 연속된 숫자들의 평균값
            //  (num - 1) / 2는 중간값에서 시작 숫자까지의 거리
            int _startNum = (total / num) - ((num - 1) / 2);

            for (int i = 0; i < num; i++)
            {
                answer[i] = _startNum + i;
            }
            return answer;
        }
    }
    class 연속된_수의_합
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            //  3, 4, 5
            foreach (var i in _solution.solution(3, 12))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //  1, 2, 3, 4, 5
            foreach (var i in _solution.solution(5, 15))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //  2, 3, 4, 5
            foreach (var i in _solution.solution(4, 14))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //  -1, 0, 1, 2, 3
            foreach (var i in _solution.solution(5, 5))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
