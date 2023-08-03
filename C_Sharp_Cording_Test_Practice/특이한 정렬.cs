using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 n을 기준으로 n과 가까운 수부터 정렬하려고 합니다. 
 * 이때 n으로부터의 거리가 같다면 더 큰 수를 앞에 오도록 배치합니다. 
 * 정수가 담긴 배열 numlist와 정수 n이 주어질 때 numlist의 원소를 
 * n으로부터 가까운 순서대로 정렬한 배열을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] numlist, int n)
        {
            // numlist 배열을 Math.Abs(x - n) 값 기준으로 오름차순 정렬합니다.
            // Math.Abs(x - n)은 각 원소 x와 n의 차이의 절대값을 의미합니다.
            // 예를 들어, n = 5일 때, numlist = [4, 9, 2]라면
            // Math.Abs(4 - 5) = 1, Math.Abs(9 - 5) = 4, Math.Abs(2 - 5) = 3
            // 따라서, 정렬 결과는 [4, 2, 9]가 됩니다.
            //int[] answer = numlist.OrderBy(x => Math.Abs(x - n)).ToArray();

            // 이후, 차이의 절대값이 같다면 원소값을 기준으로 내림차순 정렬합니다.
            // 위에서 정렬한 결과가 [4, 2, 9]이므로, 이 중 Math.Abs(x - n)이 같은 원소들을 원소값을 기준으로 정렬하면
            // [4, 9, 2]가 됩니다. 따라서 최종적인 정렬 결과는 [4, 9, 2]가 됩니다.
            // ThenByDescending : 내림 차순

            // 위 코드를 한 줄로 표현하면 다음과 같습니다.
            int[] answer = numlist.OrderBy(x => Math.Abs(x - n)).ThenByDescending(x => x).ToArray();
            return answer;
        }
    }
    class 특이한_정렬
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numlist1 = { 1, 2, 3, 4, 5 };
            int[] _numlist2 = { 10000, 20, 36, 47, 40, 6, 10, 7000 };

            int _n1 = 4;
            int _n2 = 30;

            foreach (var _n in _solution.solution(_numlist1, _n1))
            {
                Console.Write(_n + " ");
            }
            Console.WriteLine();

            foreach (var _n in _solution.solution(_numlist2, _n2))
            {
                Console.Write(_n + " ");
            }
            Console.WriteLine();

        }
    }
    */
}
