using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 배열 numbers가 주어집니다. 
 * numbers에서 서로 다른 인덱스에 있는 두 개의 수를 뽑아 더해서 만들 수 있는 모든 수를 
 * 배열에 오름차순으로 담아 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            //int[] answer = new int[numbers.Length];
            List<int> _answer = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    _answer.Add(numbers[i] + numbers[j]);
                }
            }
            _answer.Sort();
            //  중복요소 제거 후, 배열로 다시 변환9
            return _answer.Distinct().ToArray();
        }
    }
    class 두_개_뽑아서_더하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers01 = { 2, 1, 3, 4, 1 };
            int[] _numbers02 = { 5, 0, 2, 7 };

            Console.WriteLine(String.Join(", ", _solution.solution(_numbers01)));
            Console.WriteLine(String.Join(", ", _solution.solution(_numbers02)));
        }
    }
    */
}
