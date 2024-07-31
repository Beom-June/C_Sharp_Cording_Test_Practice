using System;
using System.Linq;

/* Retry
 * 정수 배열 array와 정수 n이 매개변수로 주어질 때, 
 * array에 들어있는 정수 중 n과 가장 가까운 수를 
 * return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] array, int n)
        {
            int answer = 0;
            //answer = array.OrderBy(x => Math.Abs(n - x)).First();
            // n과의 차이가 가장 작은 값들을 정렬하고, 차이가 같은 경우 작은 수를 선택
            answer = array.OrderBy(x => Math.Abs(n - x)).ThenBy(x => x).First();
            return answer;
        }
    }
    class 가까운_수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr01 = { 3, 10, 28 };
            int[] _arr02 = { 10, 11, 12 };

            Console.WriteLine(_solution.solution(_arr01, 20));
            Console.WriteLine(_solution.solution(_arr02, 13));
        }
    }
    */
}