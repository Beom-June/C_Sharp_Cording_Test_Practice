using System;
using System.Linq;

/* 함수 solution은 정수 n을 매개변수로 입력받습니다. 
 * n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴해주세요. 
 * 예를들어 n이 118372면 873211을 리턴하면 됩니다.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public long solution(long n)
        {
            char[] answer = n.ToString().ToArray();
            Array.Sort(answer);
            Array.Reverse(answer);

            return Convert.ToInt64(new string(answer));
        }
    }
    class 정수_내림차순으로_배치하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(118372));      //  873211
        }
    }
    */
}