using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 l과 r이 주어졌을 때, 
 * l 이상 r이하의 정수 중에서 숫자 "0"과 "5"로만 
 * 이루어진 모든 정수를 오름차순으로 저장한 배열을 
 * return 하는 solution 함수를 완성해 주세요.
 * 
 * 만약 그러한 정수가 없다면, -1이 담긴 배열을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int l, int r)
        {
            List<int> _answerList = new List<int>();

            for (int num = l; num <= r; num++)
            {
                if (IsMadeOfOnly05(num))
                {
                    _answerList.Add(num);
                }
            }

            if (_answerList.Count == 0)
            {
                return new int[] { -1 };
            }

            return _answerList.ToArray();
        }
        private bool IsMadeOfOnly05(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;
                if (digit != 0 && digit != 5)
                {
                    return false;
                }
                num /= 10;
            }
            return true;
        }
    }
    class 배열_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _l1 = 5, _l2 = 10;
            int _r1 = 555, _r2 = 20;

            int[] result1 = _solution.solution(_l1, _r1);
            int[] result2 = _solution.solution(_l2, _r2);

            foreach (var num in result1)
            {
                Console.Write(num + " "); // 5 50 55 500 505 550 555
            }
            Console.WriteLine();

            foreach (var num in result2)
            {
                Console.Write(num + " "); // -1
            }
            Console.WriteLine();

        }
    }
    */
}
