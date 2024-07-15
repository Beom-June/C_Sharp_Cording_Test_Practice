using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 정수 배열 numbers와 정수 num1, num2가 매개변수로 주어질 때, 
 * 
 * numbers의 num1번 째 인덱스부터 num2번째 인덱스까지 자른 
 * 정수 배열을 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] numbers, int num1, int num2)
        {
            int _length = num2 - num1 + 1;
            int[] answer = new int[_length];

            //for (int i = 0; i < _length; i++)
            //{
            //    answer[i] = numbers[num1 + i];
            //}
            Array.Copy(numbers, num1, answer, 0, _length);
            return answer;
        }
    }
    class 배열_자르기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers01 = { 1, 2, 3, 4, 5 };
            int[] _numbers02 = { 1, 3, 5 };

            Console.WriteLine(String.Join(" ", _solution.solution(_numbers01, 1, 3)));
            Console.WriteLine(String.Join(" ", _solution.solution(_numbers01, 1, 2)));
        }
    }
    */
}
