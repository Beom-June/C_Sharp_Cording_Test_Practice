using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 머쓱이는 친구들과 동그랗게 서서 공 던지기 게임을 하고 있습니다. 
 * 공은 1번부터 던지며 오른쪽으로 한 명을 건너뛰고 
 * 그 다음 사람에게만 던질 수 있습니다. 친구들의 번호가 들어있는 
 * 정수 배열 numbers와 정수 K가 주어질 때, 
 * k번째로 공을 던지는 사람의 번호는 무엇인지 return 하도록 
 * solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] numbers, int k)
        {
            int answer = numbers[(k * 2 - 2) % numbers.Length];
            return answer;
        }
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int ball = 1;
        
        for(int i = 0; i < k - 1; i++)
        {
            if(ball + 2 > numbers.Length)
            {
                ball += 2;
                ball -= numbers.Length;
            }
            else
            {
                ball += 2;
            }
        }
        answer = ball;
        return answer;
    }
    }
    class 공_던지기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers1 = { 1, 2, 3, 4 };
            int[] _numbers2 = { 1, 2, 3, 4, 5, 6 };
            int[] _numbers3 = { 1, 2, 3 };

            int _k1 = 2;
            int _k2 = 5;
            int _k3 = 3;

            Console.WriteLine(_solution.solution(_numbers1, _k1));
            Console.WriteLine(_solution.solution(_numbers2, _k2));
            Console.WriteLine(_solution.solution(_numbers3, _k3));
        }
    }
    */
}
