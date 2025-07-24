using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 머쓱이는 친구들과 동그랗게 서서 공 던지기 게임을 하고 있습니다. 
 * 공은 1번부터 던지며 오른쪽으로 한 명을 건너뛰고 그다음 사람에게만 던질 수 있습니다. 
 * 친구들의 번호가 들어있는 정수 배열 numbers와 정수 K가 주어질 때, 
 * k번째로 공을 던지는 사람의 번호는 무엇인지 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class 공_던지기
    {
        public class Solution
        {
            public int solution(int[] numbers, int k)
            {
                //  k - 1: 0부터 시작하는 인덱스로 변환
                //  한 번에 2명씩 건너 뜀 : 2 * (k - 1)
                //   % numbers.Length 인덱스 순환
                int answer = numbers[2 * (k - 1) % numbers.Length];
                return answer;
            }
        }

        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers01 = { 1, 2, 3, 4 };
            int[] _numbers02 = { 1, 2, 3, 4, 5, 6 };
            int[] _numbers03 = { 1, 2, 3 };

            Console.WriteLine(_solution.solution(_numbers01, 2));
            Console.WriteLine(_solution.solution(_numbers02, 5));
            Console.WriteLine(_solution.solution(_numbers03, 3));
        }
    }
    */
}