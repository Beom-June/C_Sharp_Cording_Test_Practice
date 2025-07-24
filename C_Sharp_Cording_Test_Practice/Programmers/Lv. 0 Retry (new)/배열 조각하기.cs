using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 정수 배열 arr와 query가 주어집니다.
 * 
 * query를 순회하면서 다음 작업을 반복합니다.
 * 
 * 짝수 인덱스에서는 arr에서 query[i]번 인덱스를 제외하고 배열의 query[i]번 인덱스 뒷부분을 잘라서 버립니다.
 * 홀수 인덱스에서는 arr에서 query[i]번 인덱스는 제외하고 배열의 query[i]번 인덱스 앞부분을 잘라서 버립니다.
 * 위 작업을 마친 후 남은 arr의 부분 배열을 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int[] query)
        {
            int _start = 0;
            int _end = arr.Length;

            for (int i = 0; i < query.Length; i++)
            {
                if (i % 2 == 0) // 짝수 인덱스
                {
                    _end = _start + query[i] + 1;
                }
                else // 홀수 인덱스
                {
                    _start += query[i];
                }
            }

            // 남은 부분 배열 생성
            int[] answer = new int[_end - _start];
            Array.Copy(arr, _start, answer, 0, _end - _start);

            return answer;
        }
    }
    class 배열_조각하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr = { 0, 1, 2, 3, 4, 5 };

            int[] _q = { 4, 1, 2 };

            foreach (var i in _solution.solution(_arr, _q))
            {
                Console.Write(i + " ");
            }
        }
    }
    */
}
