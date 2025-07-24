using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 정수를 저장한 배열, arr 에서 가장 작은 수를 제거한 배열을 리턴하는 함수, 
 * solution을 완성해주세요. 
 * 
 * 단, 리턴하려는 배열이 빈 배열인 경우엔 배열에 -1을 채워 리턴하세요. 
 * 예를들어 arr이 [4,3,2,1]인 경우는 [4,3,2]를 리턴 하고, [10]면 [-1]을 리턴 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            int[] answer = new int[] { };

            // 배열이 비었을 때
            if(arr.Length <= 1)
            {
                answer = new int[] { -1 };
                return answer;
            }

            int _temp = arr.Min();
            // x : 배열 arr의 각 요소를 순회하면서 해당 요소.
            // y : where 메서드에 의해 필터링된 배열의 요소
            answer = arr.Select(x => x).Where(y => y != _temp).ToArray();
            return answer;
        }
    }
    class 제일_작은_수_제거하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr1 = { 4, 3, 2, 1 };
            int[] _arr2 = { 10 };

            foreach (var item in _solution.solution(_arr1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in _solution.solution(_arr2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
