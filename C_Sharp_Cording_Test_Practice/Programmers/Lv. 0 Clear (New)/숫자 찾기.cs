using System;

/* Retry
 * 정수 num과 k가 매개변수로 주어질 때, 
 * num을 이루는 숫자 중에 k가 있으면 num의 그 숫자가 있는 자리 수를 
 * return하고 없으면 -1을 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int num, int k)
        {
            string _strNum = (string)num.ToString();
            char _charK = k.ToString()[0];      //  첫 번째 문자를 가져옴

            for (int i = 0; i < _strNum.Length; i++)
            {

                if (_strNum[i] == _charK)
                {
                    return i + 1;
                }
            }
            return -1;
        }
    }
    class 숫자_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();
            Console.WriteLine(_solution.solution(29183, 1));        //  3
            Console.WriteLine(_solution.solution(232443, 4));       //  4
            Console.WriteLine(_solution.solution(123456, 7));       //  -1
        }
    }
    */
}