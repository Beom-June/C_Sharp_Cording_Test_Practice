using System;

/* Retry
 * 이 문제에서 두 정수 배열의 대소관계를 다음과 같이 정의합니다.
 * 
 * 두 배열의 길이가 다르다면, 배열의 길이가 긴 쪽이 더 큽니다.
 * 배열의 길이가 같다면 각 배열에 있는 모든 원소의 합을 비교하여 다르다면 더 큰 쪽이 크고, 같다면 같습니다.
 * 
 * 두 정수 배열 arr1과 arr2가 주어질 때, 
 * 위에서 정의한 배열의 대소관계에 대하여 arr2가 크다면 -1, arr1이 크다면 1, 
 * 두 배열이 같다면 0을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] arr1, int[] arr2)
        {
            int answer = 0;
            if (arr1.Length > arr2.Length)
            {
                answer = 1;
            }
            else if (arr1.Length < arr2.Length)
            {
                answer = -1;
            }
            else
            {
                int _sumArr1 = 0;
                int _sumArr2 = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    _sumArr1 += arr1[i];
                    _sumArr2 += arr2[i];
                }
                if (_sumArr1 > _sumArr2)
                {
                    answer = 1;
                }
                else if (_sumArr1 < _sumArr2)
                {
                    answer = -1;
                }
                else
                    answer = 0;
            }
            return answer;
        }
    }
    class 배열_비교하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr11 = { 49, 13 };
            int[] _arr12 = { 100, 17, 84, 1 };
            int[] _arr13 = { 1, 2, 3, 4, 5 };

            int[] _arr21 = { 70, 11, 2 };
            int[] _arr22 = { 55, 12, 65, 36 };
            int[] _arr23 = { 3, 3, 3, 3, 3 };

            Console.WriteLine(_solution.solution(_arr11, _arr21));  // -1
            Console.WriteLine(_solution.solution(_arr12, _arr22));  //  1
            Console.WriteLine(_solution.solution(_arr13, _arr23));  //  0
        }
    }
    */
}
