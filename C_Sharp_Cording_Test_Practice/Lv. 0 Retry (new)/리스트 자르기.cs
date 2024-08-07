using System;
using System.Collections.Generic;

/* Retry
 * 정수 n과 정수 3개가 담긴 리스트 slicer 그리고 정수 여러 개가 담긴 리스트 num_list가 주어집니다. slicer에 담긴 정수를 차례대로 a, b, c라고 할 때, n에 따라 다음과 같이 num_list를 슬라이싱 하려고 합니다.
 * 
 * n = 1 : num_list의 0번 인덱스부터 b번 인덱스까지
 * n = 2 : num_list의 a번 인덱스부터 마지막 인덱스까지
 * n = 3 : num_list의 a번 인덱스부터 b번 인덱스까지
 * n = 4 : num_list의 a번 인덱스부터 b번 인덱스까지 c 간격으로
 * 올바르게 슬라이싱한 리스트를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int n, int[] slicer, int[] num_list)
        {
            List<int> answer = new List<int>();

            int a = slicer[0];
            int b = slicer[1];
            int c = slicer[2];

            switch (n)
            {
                case 1:
                    for (int i = 0; i <= b; i++)
                        answer.Add(num_list[i]);
                    break;
                case 2:
                    for (int i = a; i < num_list.Length; i++)
                        answer.Add(num_list[i]);
                    break;
                case 3:
                    for (int i = a; i <= slicer[1]; i++)
                        answer.Add(num_list[i]);
                    break;

                case 4:
                    for (int i = a; i <= b; i += c)
                        answer.Add(num_list[i]);
                    break;
            }
            return answer.ToArray();
        }
    }
    class 리스트_자르기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _slicer = { 1, 5, 2 };
            int[] _numList = { 1, 2, 4, 5, 6, 7, 8, 9 };


            foreach (var i in _solution.solution(3, _slicer, _numList))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //  2   3   4   5   6

            foreach (var i in _solution.solution(4, _slicer, _numList))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //  2   4   6
        }
    }
    */
}