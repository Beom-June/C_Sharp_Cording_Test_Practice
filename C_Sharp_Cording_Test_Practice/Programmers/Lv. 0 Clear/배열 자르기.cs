using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 numbers와 정수 num1, num2가 매개변수로 주어질 때, 
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
            int[] answer = new int[num2 - num1 + 1];
            for (int i = num1; i <= num2; i++)
            {
                answer[i - num1] = numbers[i];
            }
            return answer;
        }
    }
    class 배열_자르기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers = { 1, 2, 3, 4, 5 };
            int num1 = 1;
            int num2 = 3;

            int[] result = _solution.solution(_numbers, num1, num2);

            Console.WriteLine("Result:");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
    */
}
