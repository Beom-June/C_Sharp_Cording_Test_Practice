using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 정수 left와 right가 매개변수로 주어집니다. 
 * left부터 right까지의 모든 수들 중에서, 약수의 개수가 짝수인 수는 더하고, 
 * 약수의 개수가 홀수인 수는 뺀 수를 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int left, int right)
        {
            int answer = 0;

            //  left로 시작하여 right까지 반복문 실행
            for (int i = left; i <= right; i++)
            {
                int count = 0;
                //  1부터 i까지 반복문 실행
                for (int j = 1; j <= i; j++)
                {
                    //  하여 나누었을 때 나머지가 0이면 count 더함.
                    if (i % j == 0) 
                        count++;
                }
                //  반복문 종료 후 카운트를 2로 나눈 나머지가 0이면 
                //  짝수이므로 해당 정수 answer에 더하기
                if (count % 2 == 0) 
                    answer += i;
                //  2로 나눈 나머지가 0이 아니면 해당 정수 answer에 빼기
                else 
                    answer -= i;
            }
            return answer;
        }
    }
    class 약수의_개수와_덧셈
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(13, 17));
            Console.WriteLine(_solution.solution(24, 27));
        }
    }
    */
}