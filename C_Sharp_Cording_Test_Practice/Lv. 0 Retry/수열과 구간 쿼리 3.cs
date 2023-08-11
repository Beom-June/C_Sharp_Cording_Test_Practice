using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 정수 배열 arr와 2차원 정수 배열 queries이 주어집니다. 
 * queries의 원소는 각각 하나의 query를 나타내며, [i, j] 꼴입니다.
 * 
 * 각 query마다 순서대로 arr[i]의 값과 arr[j]의 값을 서로 바꿉니다.
 * 
 * 위 규칙에 따라 queries를 처리한 이후의 arr를 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] arr, int[,] queries)
        {
            int[] answer = new int[arr.Length];

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int x = queries[i, 0];
                int y = queries[i, 1];

                int temp = arr[x];
                arr[x] = arr[y];
                arr[y] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i];
            }

            return answer;
        }
    }
    class 수열과_구간_쿼리_3
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();
        }
    }
    */
}
