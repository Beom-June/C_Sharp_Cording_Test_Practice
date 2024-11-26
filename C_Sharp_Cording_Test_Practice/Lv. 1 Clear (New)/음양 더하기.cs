using System;

/* 어떤 정수들이 있습니다. 
 * 이 정수들의 절댓값을 차례대로 담은 정수 배열 absolutes와 이 정수들의 부호를 차례대로 담은 불리언 배열 signs가 매개변수로 주어집니다. 
 * 실제 정수들의 합을 구하여 return 하도록 solution 함수를 완성해주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;
            for (int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i] == true)
                {
                    answer += absolutes[i];
                }
                else
                {
                    answer += absolutes[i] * -1;
                }
            }
            return answer;
        }
    }
    class 음양_더하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _absolutes01 = { 4, 7, 12 };
            int[] _absolutes02 = { 1, 2, 3 };

            bool[] _signs01 = { true, false, true };
            bool[] _signs02 = { false, false, true };

            Console.WriteLine(_solution.solution(_absolutes01, _signs01));       //  9
            Console.WriteLine(_solution.solution(_absolutes02, _signs02));       //  0
        }
    }
    */
}