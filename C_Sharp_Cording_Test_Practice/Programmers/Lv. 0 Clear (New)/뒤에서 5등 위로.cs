using System;

/* 정수로 이루어진 리스트 num_list가 주어집니다. 
 * num_list에서 가장 작은 5개의 수를 제외한 수들을 오름차순으로 담은 리스트를 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            Array.Sort(num_list);
            int[] answer = new int[num_list.Length - 5]; 
            for (int i = 5; i < num_list.Length; i++)
            {
                answer[i - 5] = num_list[i];
            }
            return answer;
        }
    }
    class 뒤에서_5등_위로
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numList = { 12, 4, 15, 46, 38, 1, 14, 56, 32, 10 };
            foreach (int num in _solution.solution(_numList))
            {
                Console.Write(num + " ");
            }
        }
    }
    */
}