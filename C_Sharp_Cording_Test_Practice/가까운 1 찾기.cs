using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 배열 arr가 주어집니다. 이때 arr의 원소는 1 또는 0입니다. 
 * 정수 idx가 주어졌을 때, idx보다 크면서 배열의 값이 1인 
 * 가장 작은 인덱스를 찾아서 반환하는 solution 함수를 완성해 주세요.
 * 
 * 단, 만약 그러한 인덱스가 없다면 -1을 반환합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] arr, int idx)
        {
            int answer = -1;

            for (int i = idx; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
    }
    class 가까운_1_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr1 = { 0, 0, 0, 1 };
            int[] _arr2 = { 1, 0, 0, 1, 0, 0 };
            int[] _arr3 = { 1, 1, 1, 1, 0 };

            int _idx1 = 1, _idx2 = 4, _idx3 = 3;

            Console.WriteLine(_solution.solution(_arr1, _idx1));
            Console.WriteLine(_solution.solution(_arr2, _idx2));
            Console.WriteLine(_solution.solution(_arr3, _idx3));
        }
    }
    */
}
