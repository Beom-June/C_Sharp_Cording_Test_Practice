using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴해주세요. 
 * 예를들어 n이 12345이면 [5,4,3,2,1]을 리턴합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(long n)
        {
            int[] answer = new int[n.ToString().Length];

            for (int i = 0; n > 0; i++)
            {
                answer[i] = (int)(n % 10);
                n /= 10; 
                Console.Write(answer[i] + ", ");
            }

            return answer;
        }
    }
    internal class 자연수_뒤집어_배열로_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            long _n01 = 12345;

            string.Join(", ", _solution.solution(_n01)).ToString(); // 배열을 문자열로 변환하여 출력
        }
    }
    */
}