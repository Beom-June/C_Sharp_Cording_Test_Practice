using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 머쓱이는 행운의 숫자 7을 가장 좋아합니다. 
 * 정수 배열 array가 매개변수로 주어질 때, 
 * 7이 총 몇 개 있는지 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] array)
        {
            int answer = 0;
            int _num = 0;

            for (int i = 0; i < array.Length; i++)
            {
                _num = array[i];
                for (; _num > 0; _num /= 10)
                {
                    if (_num % 10 == 7)
                        answer++;
                }
            }

            return answer;
        }
    }
    class _7의_개수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _array1 = { 7, 77, 17 };
            int[] _array2 = { 10, 29 };

            Console.WriteLine(_solution.solution(_array1));
            Console.WriteLine(_solution.solution(_array2));
        }
    }
    */
}
